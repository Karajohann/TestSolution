using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogic
{
    public class Authedicator
    {
        /// <summary>
        /// Kanei authedicate me tin vash dedomenon kai ean ta stoixeia einai sosta
        /// epistrefei true diforetika epistrefei false
        /// </summary>
        /// <param name="username"></param>
        /// <param name="passwrod"></param>
        /// <returns></returns>
        [Obsolete("New method Checking",true)]
        public static bool Check(string username, string passwrod)
        {
            if (username.ToUpper() == "ADMIN" && passwrod.ToUpper() == "PASSWORD")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static book Checking(string username, string passwrod)
        {
            if (username.ToUpper() == "ADMIN" && passwrod.ToUpper() == "PASSWORD")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
