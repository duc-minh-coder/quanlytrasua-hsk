using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class AccountBUS
    {
        AccountDAL accountDAL = new AccountDAL();
        public List<Account> GetAccountList()
        {
            List<Account> listAccount = new List<Account>();
            DataTable dt = accountDAL.getAllAccounts();
            foreach (DataRow row in dt.Rows)
            {
                Account account = new Account(row);
                listAccount.Add(account);
            }
            return listAccount;
        }

        public bool logIn(string username, string password)
        {
            string Username = "";
            DataTable dt = accountDAL.getLoginAccount(username, getHashMD5(password).ToString());
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Username = row["Username"].ToString();
                }
            }
            if (Username != "")
                return true;
            return false;
        }

        public Account getAccountByUsername(string username)
        {
            Account account = accountDAL.getAccountByUsername(username);
            return account;
        }

        public bool updatePassword(string username, string new_password)
        {
            try
            {
                accountDAL.updatePassword(username, getHashMD5(new_password).ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool insertAccount(string username, string name, string password, string phone, string email)
        {
            try
            {
                if (phone == "SĐT")
                    phone = "";
                if (email == "Email")
                    email = "";
                accountDAL.insertAccount(username, name, getHashMD5(password).ToString(), phone, email);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool deleteAccount(string username)
        {
            try
            {
                if (accountDAL.deleteAccount(username))

                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool updateAccount(string username, string name, string phone, string email)
        {
            try
            {
                return (accountDAL.updateAccount(username, name, phone, email));

            }
            catch (Exception)
            {
                return false;
            }
        }

        public string getPasswordByUsername(string username)
        {
            try
            {
                return accountDAL.getPasswordByUsername(username);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public StringBuilder getHashMD5(string pass)
        {
            MD5 hash = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            byte[] outputBytes = hash.ComputeHash(inputBytes);
            StringBuilder hash_str = new StringBuilder();
            for (int i = 0; i < outputBytes.Length; i++)
            {
                hash_str.Append(outputBytes[i].ToString("x2"));
            }
            return hash_str;
        }
    }
}
