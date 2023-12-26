using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace cybershield_project2
{
    static class My_database
    {
       public static Dictionary<string, List<Product>>
            MyProducts = new Dictionary<string, List<Product>>();

        public static Product GetProduct(string Id, string Model)
        {
            foreach(string key in MyProducts.Keys)
            {
                for(int i = 0;  i < MyProducts[key].Count; i++)
                {
                    if ((MyProducts[key][i].Id == Id) && (MyProducts[key][i].Model == Model))
                    {
                        return MyProducts[key][i];
                    }
                }
            }
            return null;
        }
        public static List<Product> GetProduct(string Id)
        {
            if (MyProducts.ContainsKey(Id))
            {
                return MyProducts[Id];
            }
            else
            {
                return new List<Product>();
            }
        }

        /**adding Product method
        we create a method that takes 2 args first is Id as a Key and other is product as
        an object of class product the reason is that we nees to check if it exists if not 
        we proceed adding**/
        public static void AddProduct(string Id, Product product)
        {
            // here we are checking if the entered Id is already in our Dictionary if ! we execute the statment
            if (!MyProducts.ContainsKey(Id))
            {
                MyProducts.Add(Id,new List<Product>());
            }
            MyProducts[Id].Add(product);

            if (product is Tv tvProduct)
            {
                Add_Tv(tvProduct);
            }
            else if (product is Fridge fridgeProduct)
            {
                Add_Fridge(fridgeProduct);
            }
            else if (product is Stove stoveProduct)
            {
                Add_Stove(stoveProduct);
            }
        }

        private static void Add_Tv(Tv product)
        {
            FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{product.Id}; {product.Model}; {product.Price}; {product.Brand};" +
                $"{product.Size}; {product.Res_time}");

            sw.Close();
            sw.Close();
        }
        private static void Add_Fridge(Fridge product)
        {
            FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{product.Id}; {product.Model}; {product.Price}; {product.Brand};" +
               $"{product.Capacity}; {product.Noise}; {product.Electricity}");

            sw.Close();
            sw.Close();
        }
        private static void Add_Stove(Stove product)
        {
            FileStream fs = new FileStream("Products.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine($"{product.Id}; {product.Model}; {product.Price}; {product.Brand};" +
               $"{product.Heaters}");

            sw.Close();
            sw.Close();
        }

        public static void ReadProducts()
        {
            MyProducts.Clear();

            FileStream fs = new FileStream("Products.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            while (! sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] splittedData = line.Split(';');
                string Id = splittedData[0];

                if (!MyProducts.ContainsKey(Id))
                {
                    MyProducts.Add(Id, new List<Product>());
                }
                MyProducts[Id].Add(new Product(splittedData));
            }
            sr.Close();
            fs.Close();
        }
    }
}
