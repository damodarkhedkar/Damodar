using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        int id;
        string name;
        double price;
        Categary categary;

        public int Id { set; get; }
        public string Name { set; get; }
        public double Price { set; get; }
        public Categary Cate { get; set; }

        public void ShowProduct()
        {
            Console.WriteLine("Product Name: {0} Id: {1} Price: {2} Catagary Type: {3} ID: {4}",Name,Id,Price,Cate.Desc,Cate.Id);
        }


        
    }
}
