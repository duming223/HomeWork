using System;
using HomeWork._17bang;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {

            


            //author xr = new author(223, "xr");
            //article article0 = new article(xr, "111", "222");
            //articlereporsitory.reporsitory.add(article0);


            //foreach (var item in articlereporsitory.reporsitory)
            //{
            //    console.writeline(item.body);
            //}


            #region 17BangTest1
            //Author FreeMan = new Author() { Name = "FreeMan", ID = 123 };

            //Article article1 = new Article()
            //{
            //    author = FreeMan,
            //    Tile = "FreeMAN发布了一篇文章",
            //    Boyd = "引用类型变量与实例的关系：引用类型变量里储存的是对象的内存的地址",
            //    PublishDate = DateTime.Now,
            //};

            //Console.WriteLine("----------------------------------------------------------------");

            //Article article2 = new Article()
            //{
            //    author = WalkMan,
            //    Tile = "WalkMan发布了一篇文章",
            //    Boyd = "实际上，变量表示了储存位置，并且每个变量都有一个类型，以决定什么样的值能够存入变量",
            //    PublishDate = DateTime.Now
            //};
            //IPublish<Article> Getpublish = article1;
            //Getpublish.Publish(article1);
            //Getpublish.Publish(article2);

            //IArticleRepository iar = new ArticleReporsitory();
            //iar.Add(article1);
            //iar.Add(article2);


            //var x = iar.Get();//获取所有文章
            //Console.WriteLine("***************获取所有文章****************");
            //foreach (var item in x)   
            //{
            //    Console.WriteLine(item.Tile );
            //}
            //Console.WriteLine("********************************************");

            //Console.WriteLine("********通过作者名查找文章****************");
            //iar.GetBy("wa");     //通过作者名称查找文章 
            #endregion
        }


            #region xml基础增删改查
            //XML xML = new XML();
            //XElement xElement = xML.GetYzxml();
            //XDocument xDocument = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"), xElement);
            //xDocument.Save(@"C:\Users\meing\Desktop\yz.xml");

            //XElement element = XElement.Load(@"C:\Users\meing\Desktop\yz.xml");
            //element.Add(new XElement("article",
            //        new XElement("id", 2),
            //        new XElement("title", "++++++++++"),
            //        new XElement("authdrld", "xr")));

            //element.Save(@"C:\Users\meing\Desktop\yz.xml"); 
           

            //var article = from x in element.Descendants()
            //              where x.Name == "article"
            //              where (int)x.Element("id") == 2
            //              select x;
            //foreach (var item in article.ToList())
            //{
            //    item.SetAttributeValue("Draft", false);
            //    item.SetElementValue("title", "C#进阶-8：异步和并行");
            //}
            //Console.WriteLine(element);
 #endregion
        
    }
}
