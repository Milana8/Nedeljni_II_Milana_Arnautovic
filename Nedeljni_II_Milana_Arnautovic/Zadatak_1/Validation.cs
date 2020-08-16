using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zadatak_1
{
    class Validation
    {
        /// <summary>
        /// Validation that the entered value is a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsANumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return false;

            foreach (char x in input)
            {
                if (x < '0' || x > '9')
                    return false;
            }
            return true;
        }

        /// <summary>
        /// Password validation
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Password(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            return new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,60}$").IsMatch(password);
        }

        /// <summary>
        /// IdCard validation
        /// </summary>
        /// <param name="idcNo"></param>
        /// <returns></returns>
        public static bool IDCard(string idcNo)
        {
            if (!IsANumber(idcNo) || idcNo.Length != 9)
                return false;
            return true;
        }

        /// <summary>
        /// Account Number validation
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static bool AccountNumber(string account)
        {
            if (!IsANumber(account) || account.Length != 18)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Healt Insurance number validation
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool HealthInsuranceNumber(string number)
        {
            if (!IsANumber(number) || number.Length != 10)
            {
                return false;
            }
            return true;
        }
    }
}
    