using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblemsException;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
    }
}