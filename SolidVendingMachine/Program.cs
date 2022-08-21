namespace SolidVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var menuLoader = new CsvMenuLoader();
            var vendingMachine = new VendingMachine(menuLoader);
            vendingMachine.Start();


            new HighEfficiencyVendingMachine(new JsonMenuLoader()).Start();
        }
    }
}