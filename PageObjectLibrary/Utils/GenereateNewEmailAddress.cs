using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectLibrary.Utils
{
    public class GenereateNewEmailAddress
    {
        private static string _user = "joaquin";
        private static string _domain = "@test.com";
        private string email;
        public GenereateNewEmailAddress()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int number = r.Next();
            email = _user + number.ToString() + _domain;
        }
        public string generateEmail()
        {
            return email;
        }
    }
}
