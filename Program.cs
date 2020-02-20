using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Categary c = new Categary { Desc="Hr",Id=12};
            Product p = new Product {Id=1234,Name="SMX",Price=1000.25,Cate=c};
            p.ShowProduct();
            Console.Read();
        }
    }
}
