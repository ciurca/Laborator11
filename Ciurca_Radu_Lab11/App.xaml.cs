using Ciurca_Radu_Lab11.Data;
namespace Ciurca_Radu_Lab11
{
    public partial class App : Application
    {
        public static ShoppingListDatabase Database { get; set; }
        public App()
        {
            Database = new ShoppingListDatabase(new RestService());
            MainPage = new NavigationPage(new ListEntryPage());
        }
    }
}