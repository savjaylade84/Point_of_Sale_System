using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjPointOfSalesSystem
{
    class Generate
    {

        /// <summary>
        /// generate random userid when the admin create account
        /// </summary>
        /// <param name="length">determine of the length of userid</param>
        /// <returns>generate userid</returns>
        public static string UserId(int length) {

            Random rand = new Random();
            StringBuilder builder = new StringBuilder();
            while (0 < length--)
            {

                builder.Append(rand.Next(length).ToString());

            }
            return builder.ToString();
        }

        /// <summary>
        /// generate random password when the admin create account
        /// </summary>
        /// <param name="length"> determine the length of the password that
        /// will generate</param>
        /// <returns>generate password</returns>
        public static string Password(int length) {
        
        const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random rand = new Random();
        StringBuilder builder = new StringBuilder();
            while (0 < length--) {

                builder.Append(valid[rand.Next(valid.Length)]);
            
            } 

                return builder.ToString();
            
        }

    }
}
