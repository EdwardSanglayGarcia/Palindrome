using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        private string userInput;

        public string UserInput 
        {
            get  { return userInput; }
            set  { userInput = value; }
        }

        public string CheckPalindrome()
        {
            string returnValue = string.Empty;
            char[] reversedUserInput = userInput.ToCharArray();
            Array.Reverse(reversedUserInput);

            if (userInput == new string(reversedUserInput))
            {
                returnValue = "Accepted";
            }
            else
            {
                returnValue = "Not Accepted";

            }

            return returnValue;
        }
    }
}
