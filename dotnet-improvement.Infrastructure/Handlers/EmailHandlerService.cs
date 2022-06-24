
using dotnet_improvement.Core.Domain.Args;
using dotnet_improvement.Infrastructure.Services;

namespace dotnet_improvement.Infrastructure.Handlers
{
    public class EmailHandlerService
    {
        public void OnUserRegistred(object sender, UserDataEventArgs args)
        {
            EmailService discountService = new EmailService(); // for test
            discountService.Send(args.Email, "Successful Register");
        }
    }
}
