using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_improvement.Core.Interfaces
{
    public interface IEmailService
    {
        void Send(string email, string message);
    }
}
