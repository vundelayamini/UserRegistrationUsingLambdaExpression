using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegex;

namespace MsTestUserRegex
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();

        /// <summary>
        /// UC1-Validate for the firstname
        /// </summary>
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            string FirstName = "Yamini";
            //Act
            bool result = pattern.ValidateFirstName(FirstName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>  
        /// UC2-Valid for LastName
        /// </summary>
        [TestMethod]
        public void GivenUser_LastName_WhenValidate_ShouldReturn_True()
        {
            string LastName = "Mahi";
            //Act
            bool result =pattern.ValidateLastName(LastName);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC3-Valid for Email
        /// </summary>
        [TestMethod]
        public void Given_EmailId_WhenValidate_ShouldReturn_True()
        {

            string Email = "yamini1235@gmail.com";
            //Act
            bool result = pattern.ValidateEmail(Email);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC4- valid mobile number
        /// </summary>
        [TestMethod]
        public void Given_MobileNumber_WhenValidate_ShouldReturn_True()
        {
            string MobileNumber = "91 9014066209";
            //Act
            bool result = pattern.ValidateMobile(MobileNumber);
            //Assert
            Assert.IsTrue(result);
        }
        /// <summary>
        /// UC5-predefined password
        /// </summary>
        [TestMethod]
        public void Given_Password_WhenValidate_ShouldReturn_True()
        {
            //Arrange
            string Password = "yaminimahi@12";
            //Act
            bool result = pattern.ValidatePassword(Password);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        [DataRow("abc@ygmail.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@abcd.com")]
        [DataRow("abc111@amit.com")]
        [DataRow("abc-100@gmail.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.co")]
        [DataRow("abc+100@gmail.com")]
        public void ValidateEmailId_Should_return_true(string email)
        {
            Assert.IsTrue(pattern.ValidateEmail(email));
        }

    }

    
    
}






