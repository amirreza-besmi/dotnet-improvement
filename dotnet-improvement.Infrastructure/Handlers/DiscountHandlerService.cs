using dotnet_improvement.Core.Domain.Args;
using dotnet_improvement.Infrastructure.Services;

namespace dotnet_improvement.Infrastructure.Handlers
{
    public class DiscountHandlerService
    {
        public void OnUserRegistred(object sender, UserDataEventArgs args)
        {
            DiscountService discountService = new DiscountService(); // for test
            discountService.SetDiscountCode(args.Email, "Off");
        }
    }
}
