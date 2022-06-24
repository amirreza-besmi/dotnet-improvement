using dotnet_improvement.Core.Services;
using dotnet_improvement.Infrastructure.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_improvement.Presentation.Testers
{
    public static class UserRegistrationTester
    {
        public static void TestUserRegistration()
        {
            UserService userService = new UserService(); // for test
            UserEmailHandlerService emailHandlerService = new UserEmailHandlerService(); // for test
            UserDiscountHandlerService discountHandlerService = new UserDiscountHandlerService(); // for test
            userService.UserRegistered += emailHandlerService.OnUserRegistred;
            userService.UserRegistered += discountHandlerService.OnUserRegistred;
            userService.RegisterUser("amirbesmi74@gmail.com");
        }
    }
}
