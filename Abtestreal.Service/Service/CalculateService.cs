using Abtestreal.DAL.Models;
using Abtestreal.Service.Abstract.Interfaces;
using Abtestreal.Service.Mappers;
using Abtestreal.Service.Models;
using System;
using System.Collections.Generic;

namespace Abtestreal.Service.Service
{
    public class CalculateService
    {
        IApplicationService _applicationService;
        private double countA;
        private double countR;
        public CalculateService(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public string Calc(DateTime dateRegistration, DateTime lastActivityDate)
        {
            try
            {
                List<UserService> userListA = new List<UserService>();
                List<UserService> userListR = new List<UserService>();

                List<UserRegDal> users = (List<UserRegDal>)_applicationService.GetAll();

                foreach (var user in users)
                {
                    if (user.LastActivityDate <= lastActivityDate)
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
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
