using System;

namespace dotnet_improvement.Core.Domain.Args
{
    public class UserDataEventArgs : EventArgs
    {
        public string Email { get; set; }
    }
}
