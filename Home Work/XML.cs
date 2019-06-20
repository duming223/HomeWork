using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork
{
    class XML
    {
        public void GetXML()
        {
            XElement lucakystack = new XElement
                ("luckystack",
                new XComment("源栈欢迎你！"),
                new XElement("location", "CQ",
                new XAttribute("head", true)),
                new XElement("teachers",
                new XElement("name", "飞哥",
                new XAttribute("position", "head"),
                new XAttribute("age", 11)),
                new XElement("name", "小鱼", new XAttribute("position", "UI")),
                new XElement("name", "AJ")
                )
             );

            Console.WriteLine(lucakystack);
            //XDocument xDocument = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    lucakystack);
            //xDocument.Save(@"C:\Users\meing\Desktop\XML.xml");
        }

        public XElement GetYzxml()
        {
            XElement yz = new XElement
                ("articles",new XComment("以下存放所有“源栈”所有文章 "), 
                new XElement("article", 
                        new XAttribute("Draft", false),
                        new XElement("id", 1),
                        new XElement("title", "源栈培训：C#进阶-7：Linq to XML"),
                        new XElement("body", "什么是XML（EXtensible Markup Language）"),
                        new XElement("authorID", 1),
                        new XElement("pubblishDate", "2019/6/18 18:15"),
                                new XElement("comments",
                                         new XElement("comment",
                                         new XAttribute("commend", true),
                                         new XElement("id", 12),
                                         new XElement("body", "不错！")),
                                         new XElement("comment",
                                         new XElement("authorID", 2),
                                         new XElement("id", 14),
                                         new XElement("dody", "太难了"),
                                         new XElement("authorID", 3)))),
                                 new XElement("article",
                                         new XAttribute("Draft", true),
                                         new XElement("id", 2),
                                         new XElement("title", " 源栈培训：C#进阶-6：异步和并行"),
                                         new XElement("authorID", 1)));
            return yz;
        }
    }
}

