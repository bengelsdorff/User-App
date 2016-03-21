using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp.Controllers;
using UserApp.Core.Interfaces;
using Moq;
using System;
using UserApp.Domain;
using System.Threading.Tasks;

namespace UserApp.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        [TestMethod]
        public void SignIn_Is_Not_Null()
        {
            // Arrange
            var mockUserBusinessLogic = Mock.Of<IUserBusinessLogic>();
            Mock.Get(mockUserBusinessLogic)
               .Setup(s => s.SignIn(string.Empty, string.Empty))
               .ReturnsAsync(new Tuple<AuthenticationStatus, User>(AuthenticationStatus.Invalid, null));

            UserController controller = new UserController(mockUserBusinessLogic);

            // Act
            ViewResult result = controller.SignIn() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }


    }
}
