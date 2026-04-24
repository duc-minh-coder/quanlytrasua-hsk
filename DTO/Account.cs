using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        private string _Username;

        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private string _Realname;

        public string Realname
        {
            get { return _Realname; }
            set { _Realname = value; }
        }

        private int _Type;

        public int Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _PhoneNumber;

        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set { _PhoneNumber = value; }
        }
        public Account()
        { }

        public Account(string Username, string Password, string Realname, int Type, string Email, string PhoneNumber)
        {
            this._Username = Username;
            this._Password = Password;
            this._Realname = Realname;
            this._Type = Type;
            this._Email = Email;
            this._PhoneNumber = PhoneNumber;
        }

        public Account(DataRow r)
        {
            this._Username = r["Username"].ToString();
            this._Password = r["Password"].ToString();
            this._Realname = r["Realname"].ToString();
            this._Type = (int)r["Type"];
            this._Email = r["Email"].ToString();
            this._PhoneNumber = r["PhoneNumber"].ToString();
        }
    }
}
