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
using Abtestreal.Service.Service;

namespace Abtestreal.WebApp.Controllers
{
    public class UserRegController : Controller
    {

        IApplicationService _applicationService;
        public UserRegController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }


        // Получение значений всех пользователей
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
                CalculateService calculate = new CalculateService(_applicationService);
                string str = calculate.Calc(dateRegistration, lastActivityDate);
                return Ok(str);
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }
        }



        // Сделать запись
        [HttpPost]
        [Route("api/CreateApplication")]
        public IActionResult CreateApplication([FromBody] UserService user)
        {
            _applicationService.Create(user);
            return Ok("OK!");
        }
    }

}
