using dotnet_improvement.Core.Interfaces;
using System;

namespace dotnet_improvement.Infrastructure.Services
{
    public class EmailService : IEmailService
    {
        public void Send(string email, string message)
        {
            Console.WriteLine($"Email [{message}] sent for [{email}]...");
        }
    }
}
