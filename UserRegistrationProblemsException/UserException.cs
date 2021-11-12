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
        public string validLastName()
        {
            string lastname = "^[A-Z]{1}[a-zA-Z]{2}$";      //Expression for first letter is capital and maximum charactor is 3
            Regex regex = new Regex(lastname);

            try
            {
                if (regex.IsMatch(message))
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

        //This method for validation of email id
        public string ValidEmailId()
        {
            string emailid = "^[a-z]{3}[.][a-z0-9]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; //Expression for gmail format
            Regex regex = new Regex(emailid);

            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(mail + "-- > Valid");
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine(mail + "-- > InValid");
                    return "Invalid";
                }
            }
            catch(ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException,"Invalid");
            }
        }


        //We are using this method to match pattern of mobile no
        public string mobileFormat()
        {
            string Mobnumber = "^[0-9]{1,2}[ ]{1}[0-9]{10}$";  //Expression for Validating mobileFormating
            Regex regex = new Regex(Mobnumber);

            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(number + "-- > Valid");
                    return "Valid";
                }
                else
                {
                    //Console.WriteLine(number + "-- > InValid");
                    return "Invalid";
                }
            }
            catch(ArgumentNullException ex)
            { 
                
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException,"Invalid");
            }
        }
    }
}

