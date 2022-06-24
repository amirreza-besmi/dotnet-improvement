using dotnet_improvement.Core.Domain.Args;
using dotnet_improvement.Core.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_improvement.Core.Services
{
    public class UserService
    {
        public event UserEvents.UserRegisteredEventHandler UserRegistered;
        
        public void RegisterUser(string email)
        {
            Console.WriteLine($"User [{email}] has been registered...");
            OnUserRegistered(this, new UserDataEventArgs() { Email = email });
        }

        // event invokers
        protected void OnUserRegistered(object sender, UserDataEventArgs args)
        {
            UserRegistered?.Invoke(sender, args);
        }
    }
}
