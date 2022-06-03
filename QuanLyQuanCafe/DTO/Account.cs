using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Account
    {
        private string userName;
        private string password;
        private string displayName;
        private int type;

        public Account(string userName, string displayName, int type, string password = null)
        {
            this.Username = userName;
            this.DisplayName = displayName;
            this.Type = type;
            this.Password = password;
        }
        public Account(DataRow row)
        {
            this.Username = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString() ;
            this.Type = (int)row["type"];
            this.Password = row["Password"].ToString() ;
        }

        public string Username { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
