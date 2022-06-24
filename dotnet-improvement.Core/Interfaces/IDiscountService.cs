
namespace dotnet_improvement.Core.Interfaces
{
    public interface IDiscountService
    {
        void SetDiscountCode(string email, string discountCode);
    }
}
