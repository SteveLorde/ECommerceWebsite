using WebApplicationRazor.Models;

namespace ECommerceWebsite.App.Services
{
    public static class WarehouseCRUDService
    {
        public static void AddItem(string name, int price, string description)
        {
            Item item= new(name, price, description);
            //DATABASE ADD CODE
        }
    }
}
