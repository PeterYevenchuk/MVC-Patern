namespace MVC
{
    internal class MainViewShop : View
    {
        public IView view;
        const string NAME_SHOP = "======== SHOP ========";
        public MainViewShop()
        {
            Console.WriteLine(NAME_SHOP);
        }
   
        public override void SendCommand()
        {
            while (isEmpty)
            {
                Console.Write("Please enter number Department (Products = 1,Techniques = 2 or Toys = 3) : ");
                inputCommand = Console.ReadLine();

                CheckCommandIsNull = inputCommand;

                if (isEmpty) return;

                switch (inputCommand)
                {
                    case "1":
                        view = new ProductsViewShop();
                        break;
                    case "2":
                        view = new TechniquesViewShop();
                        break;
                    case "3":
                        view = new ToysViewShop();
                        break;
                    default:
                        Console.WriteLine("Command is not found!!");
                        isEmpty = true;
                        break;
                }
                if(!isEmpty) view.SendCommand();
            }
        }
    }
}