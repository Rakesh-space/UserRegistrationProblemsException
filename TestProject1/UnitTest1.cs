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
                string actual = testing.validFirstName();
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
                string actual = testing.validFirstName();
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

            //Act
            UserException testing = new UserException(message);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
