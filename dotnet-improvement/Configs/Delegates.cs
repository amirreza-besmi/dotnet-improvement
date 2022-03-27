
namespace dotnet_improvement.Configs
{
    public static class Delegates
    {
        public delegate string GetTextDelegate();
        public delegate double CalcNumberDelegate(int firstNumber, int secondNumber);

        // Events
        public delegate void SuccessEvent();
    }
}
