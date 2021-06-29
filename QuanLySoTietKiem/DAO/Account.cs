using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySoTietKiem.DAO
{
    public class Account
    {
        private static Account instance;

        public static Account Instance { get { if (instance == null) instance = new Account(); return instance; } set => instance = value; }

        public string Encrypt(string text)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(text));
                return Convert.ToBase64String(data);
            }
        }
        public bool Login(string Username, string Password)
        {
            string EncryptedPass = Encrypt(Password);
            int data = (int)ExecuteQuery.Instance.ExecuteScalar(String.Format("select count(*) from DANGNHAP where TenDN = '{0}' and MatKhau = '{1}'", Username, EncryptedPass));
            return data == 1;
        }
        public int ChangePassword(string Username, string oldPass, string newPass)
        {
            string EncryptedOldPass = Encrypt(oldPass);
            string EncryptedNewPass = Encrypt(newPass);
            return ExecuteQuery.Instance.ExecuteNoneQuery("QLKS_ChangePassword @Username , @OldPassword , @NewPassword",
                new object[] { Username, EncryptedOldPass, EncryptedNewPass });
        }

        public DataRow GetInfoAcc(string username)
        {
            return ExecuteQuery.Instance.ExecuteReader(String.Format("select * from DANGNHAP where TenDN = '{0}'", username)).Rows[0];
        }

        public bool InsertAccount(string Username, string Password, int Type)
        {
            string EncryptedPass = Encrypt(Password);
            //if (DisplayName == null) DisplayName = Username;
            return ExecuteQuery.Instance.ExecuteNoneQuery(String.Format("INSERT INTO [dbo].[DANGNHAP]([TenDN],[MatKhau],[TenHienThi],[LoaiTK])VALUES ('{0}','{1}','{2}',{3})", Username, EncryptedPass, Username, Type)) > 0;
        }

        public DataRow GetPhanQuyen(int loai)
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from PHANQUYEN where Loai =" + loai).Rows[0];
        }

        public DataTable GetListPhanQuyen()
        {
            return ExecuteQuery.Instance.ExecuteReader("select * from PHANQUYEN");
        }

        public int GetTypeAccount(string tendn)
        {
            return (int)ExecuteQuery.Instance.ExecuteScalar(String.Format("select LoaiTK from DANGNHAP where TenDN = '{0}'", tendn));
        }

    }
}
