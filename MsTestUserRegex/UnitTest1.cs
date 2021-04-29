using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestUserRegex;

namespace MsTestUserRegex
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();

        //Happy Test Cases(Test Cases pass The Entry)
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

        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void Given_FistName_WhenValidate_ShouldReturnFalse()
        {
            string firstName = "yamini";
            //Act
            bool result = pattern.ValidateFirstName(firstName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Given_LastName_WhenValidate_ShouldReturnFalse()
        {
            string lastName = "mahi";
            //Act
            bool result = pattern.ValidateFirstName(lastName);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Given_EmailId_WhenValidate_ShouldReturnFalse()
        {
            string email = "yaminimahi.com";
            //Act
            bool result = pattern.ValidateEmail(email);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Given_MobileNumber_WhenValidate_ShouldReturnFalse()
        {
            string mobileNumber = "91 0901406620";
            //Act
            bool result = pattern.ValidateMobile(mobileNumber);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void Given_Password_WhenValidate_ShouldReturnFalse()
        {
            string password = "yamini3@12";
            //Act
            bool result = pattern.ValidatePassword(password);
            //Assert
            Assert.IsFalse(result);
        }
       

    }

    
    
}






