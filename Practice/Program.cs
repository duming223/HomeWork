using System;
using System.Threading;
using System.Threading.Tasks;


namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //test
            Console.WriteLine(DateTime.Now.ToString("yyyy MM dd hh mm ss"));
            Console.WriteLine(DateTime.Now.ToString());
        }
    }

    class Vehicle
    {
        public virtual void Ran()
        {
            Console.WriteLine("i m running");
        }
    }

    class Car : Vehicle
    {
        public override void Ran()
        {
            Console.WriteLine("cai is running");
        }
    }

    class RaceCar : Car
    {
        public override void Ran()
        {
            Console.WriteLine("racecar is running");
        }
    }

    class F1 : RaceCar
    {
        public override void Ran()
        {
            Console.WriteLine("F1 is running");
        }
    }

    #region 事件
    interface IProductFactoy
    {
        Product MakeProduct();
    }
    class Logger
    {
        public void Log(Product product)
        {
            Console.WriteLine("产品‘{0}’在{1}生产，价格是{2}。", product.Name, DateTime.UtcNow, product.Price);
        }
    }

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WarpProduct(IProductFactoy productFactoy, Action<Product> action)// 传入一个接口代替委托 降低方法的耦合度              也可以传一个logger实例对象 代替Action委托
        {
            Box box = new Box();
            Product product = productFactoy.MakeProduct();
            action(product);
            box.Product = product;
            return box;
        }
    }
    class PizzaFactory : IProductFactoy
    {
        public Product MakeProduct()
        {
            Product product = new Product();
            product.Name = "Pizza";
            product.Price = 12;
            return product;
        }
    }
    class ToyCarFactory : IProductFactoy
    {
        public Product MakeProduct()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            product.Price = 100;
            return product;
        }
    }
    #endregion
}
