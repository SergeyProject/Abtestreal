using System;
using System.Collections.Generic;
using Abtestreal.BLL.Services;
using Abtestreal.DAL.Models;
using Abtestreal.DAL.Repository.Interfaces;
using Abtestreal.Service.Abstract.Interfaces;
using Abtestreal.Service.Models;
using Abtestreal.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Abtestreal.WebApp.Mappers;

namespace Abtestreal.WebApp.Controllers
{
    public class UserRegController : Controller
    {

        IApplicationService _applicationService;
        public UserRegController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        // Получение каких либо значений
        [HttpGet]
        [Route("api/GetAllApp")]
        public IActionResult GetAllApp()
        {
            try
            {                
                return Ok(_applicationService.GetAll());
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [HttpGet]
        [Route("api/GetCalculateApp")]
        public IActionResult GetCalculateApp(DateTime dateRegistration, DateTime lastActivityDate)
        {
            try
            {
                List<UserService> userListA = new List<UserService>();
                List<UserService> userListR = new List<UserService>();
                int countA = 0;
                int countR = 0;
                List<UserRegDal> users = (List<UserRegDal>)_applicationService.GetAll();
               
                foreach(var user in users)
                {
                    if (user.LastActivityDate >= lastActivityDate)
                    { 
                        userListA.Add(user.ToUserRegService());
                        countA++;
                    }
                    if (user.RegistrationDate >= dateRegistration)
                    {
                        userListR.Add(user.ToUserRegService());
                        countR++;
                    }
                }
                double result = countA / countR * 100;
                return Ok(result.ToString());
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }



        // Зделать запись
        [HttpPost]
        [Route("api/CreateApplication")]
        public IActionResult CreateApplication([FromBody] UserService user)
        {
            _applicationService.Create(user);
            return Ok("OK!");
        }
    }

}
