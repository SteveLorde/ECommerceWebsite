using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationRazor.Models
{
    public class Item
    {
        int id { get; set;}
        string name { get; set;}
        string description { get; set;}
        int price { get; set;}

        public Item(string name, int price, string description)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}