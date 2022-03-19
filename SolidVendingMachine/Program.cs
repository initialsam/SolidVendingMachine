namespace SolidVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuLoader = new JsonMenuLoader();
            var vendingMachine = new VendingMachine(menuLoader);
            vendingMachine.Start();
        }
    }
}