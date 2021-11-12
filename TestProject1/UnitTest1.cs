using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblemsException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //AAA Methodology

            //Arrange
            string message = null;
            string expected = "invalid";

            try
            {
                //Act
                UserException testing = new UserException(message);      
                string actual = testing.validFirstName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }

        [TestMethod]
        public void TestLastName()
        {
            //AAA Methodology

            //Arrange
            string message = null;
            string expected = "invalid";

            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.validLastName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }

        [TestMethod]
        public void TestValidGmail()
        {
            //AAA Methodology

            //Arrange
            string message = null;
            string expected = "invalid";

            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.ValidEmailId();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }

        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

                //Arrange
                string message = null;
                string expected = "valid";
            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.mobileFormat();
            }
            catch(CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void TestPassword()
        {
            //AAA Methodology

            //Arrange
            string message = null;
            string expected = "valid";

            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.passwordFormat();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void TestUpperCase()
        {
            //AAA Methodology
            //Arrange
            string message = null;
            string expected = "valid";

            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.UpperCaseFormat();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void TestOneNumeric()
        {
            //AAA Methodology

            //Arrange
            string message = null;
            string expected = "valid";

            try
            {
                //Act
                UserException testing = new UserException(message);
                string actual = testing.OneNumeric();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
