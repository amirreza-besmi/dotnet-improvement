using dotnet_improvement.Core.Services;
using dotnet_improvement.Infrastructure.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_improvement.Presentation.Testers
{
    public static class UserRegisterTester
    {
        public static void TestUserRegister()
        {
            UserService userService = new UserService(); // for test
            EmailHandlerService emailHandlerService = new EmailHandlerService(); // for test
            DiscountHandlerService discountHandlerService = new DiscountHandlerService(); // for test
            userService.UserRegistered += emailHandlerService.OnUserRegistred;
            userService.UserRegistered += discountHandlerService.OnUserRegistred;
            userService.RegisterUser("amirbesmi74@gmail.com");
        }
    }
}
