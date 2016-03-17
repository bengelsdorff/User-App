using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UserApp.Core;
using UserApp.Domain;
using UserApp.Filters;
using UserApp.Models;

namespace UserApp.Controllers
{
    public class UserController : Controller
    {

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAjaxAntiForgeryToken]
        public async Task<AuthenticationStatus> SignIn(string email, string password)
        {
            var result = await new UserBusinessLogic(new Domain.Context()).SignIn(email, password);

            if (result.Item1 == AuthenticationStatus.Valid)
            {
                SessionManager.User = result.Item2;

            }

            return result.Item1;
        }

    }
}