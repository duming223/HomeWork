using System;

namespace practice
{
    class Program
    {
        static void Main(string[] args)
        {
            WrapFactory wrapFactory = new WrapFactory();
            IProductFactoy MakePizza = new PizzaFactory();
            IProductFactoy MakeToyCar = new ToyCarFactory();

            Logger logger = new Logger();
            Action<Product> log = new Action<Product>(logger.Log);//回调函数：通过委托类型参数 传入主调方法的一个被调用方法 主调方法可以根据自己的逻辑来决定是否调用这个方法 别名好莱坞方法。

            // PizzaFactory pizza = new PizzaFactory();
            // ToyCarFactory toycar = new ToyCarFactory();
             
            // Func<Product> MakePizza = new Func<Product>(pizz.MakePizza);
            // Func<Product> MakeToyCar = new Func<Product>(toycar.MakeProduct);     //委托

            Box box1 = wrapFactory.WarpProduct(MakeToyCar, log);
            Box box2 = wrapFactory.WarpProduct(MakePizza, log);

            // Console.WriteLine("{0}在{1}生产 价格是{2}",box1.Product.Name,wrapFactory,box2.Product.Price);
        }
    }
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
}
