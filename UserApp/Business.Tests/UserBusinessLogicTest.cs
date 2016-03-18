using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UserApp.Domain.Interfaces;
using UserApp.Core;
using System.Data.Entity;
using UserApp.Domain;

namespace Business.Tests
{
    [TestClass]
    public class UserBusinessLogicTest
    {
        [TestMethod]
        public void SignIn_Is_Not_Null()
        {
            // Arrange
            var mockSet = new Mock<DbSet<User>>();

            var mockContext = Mock.Of<IContext>();

            Mock.Get(mockContext)
              .Setup(s => s.Users)
              .Returns(mockSet.Object);

            UserBusinessLogic userBusinessLogic = new UserBusinessLogic(mockContext);
            
            // Act
            var result = userBusinessLogic.SignIn(string.Empty, string.Empty);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
