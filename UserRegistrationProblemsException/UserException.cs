using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemsException
{
    public class UserException
    {
        public string message;
        public UserException(string message)
        {
            this.message = message;

        }
        //We are using this method to match pattern of first name
        public string validFirstName()
        {
            string firstname = "^[A-Z]{1}[a-zA-Z]{2}$";  //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(firstname);
            try
            {
                if (regex.IsMatch(message))
                {
                    // Console.WriteLine(message + "-->Valid");
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine(message + "--->Invalid");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException )
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException,"Invalid");
               // Console.WriteLine(ex);
            }
        }

        //We are using this method to match pattern of last name
        public string validLastName(string name)
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            try
            {
                if (regex.IsMatch(name))
                {
                    //Console.WriteLine(name + "-->Valid");
                    return "Valid";
                }
                else
                {
                    // Console.WriteLine(name + "--->Invalid");
                    return "Invalid";
                }
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException,"Invalid");
            }
        }
    }
}

