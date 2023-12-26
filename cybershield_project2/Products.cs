using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace cybershield_project2
{
    public class Product
    {
        public string Id, Model, Brand, Price;
        

        public Product(string[] data)
        {
            Id = data[0];
            Model = data[1];
            Brand = data[2];
            Price = data[3];
        }

        public Product (string id, string model, string brand, string price) 
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
        }
        public string id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string model
        {
            get { return Model; }
            set { Model = value; }
        }
        public string brand
        {
            get { return Brand; }
            set { Brand = value; }
        }
        public string price
        {
            get { return Price; }
            set { Price = value; }
        }

    }

    class Tv : Product
    {
        public string Size, Res_time;

        public Tv(string[] data) : base(data)
        {
            Size = data[4];
            Res_time = data[5];
        }
        public Tv(string size, string res_time, string id, string model, string brand, string price) : base(id, model, brand, price)
        {
            Size = size;
            Res_time = res_time;
        }
        public string size
        {
            get { return Size; }
            set {
                if (false)
                {
                    throw new ArgumentException("Size can't be less than 0"); //checking here if this works and apply it instead of use catch and try 
                }
                else 
                { 
                    Size = value; 
                }
            }
        }
        public string res_time
        {
            get { return Res_time; }
            set { Res_time = value; }
        }

    }
    class Fridge : Product
    {
        public string Capacity, Electricity, Noise;

        public Fridge(string[] data) : base(data)
        {
            Capacity = data[4];
            Electricity = data[5];
            Noise = data[6];
        }
        public Fridge(string capacity, string electricity, string noise, string id, string model, string brand, string price) : base(id, model, brand, price)
        {
            Capacity = capacity;
            Electricity = electricity;
            Noise = noise;
        }
        public string capacity
        {
            get { return Capacity; }
            set { Capacity = value; }
        }
        public string electricity
        {
            get { return Electricity; }
            set { Electricity = value; }
        }
        public string noise
        {
            get { return Noise; }
            set { Noise = value; }
        }

    }
    class Stove : Product
    {
        public string Heaters;

        public Stove(string[] data): base(data)
        {
            
            Heaters = data[4]; 

        }
        public Stove(string heaters, string id, string model, string brand, string price) : base(id, model, brand, price)
        {
            Heaters = heaters;
        }
        public string heaters
        {
            get { return Heaters; }
            set { Heaters = value; }
        }

    }

    
}
