using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork._17bang
{
    class XML
    {
        public const string userlocation = "C:\\Users\\meing\\Desktop\\user.xml";
        public const string articlelocation = "C:\\Users\\meing\\Desktop\\article.xml";
        public const string commentlocation = "C:\\Users\\meing\\Desktop\\comment.xml";
        public const string problemlocation = "C:\\Users\\meing\\Desktop\\problem.xml";
        public const string suggestlocation = "C:\\Users\\meing\\Desktop\\suggest.xml";
     
        public XElement GetUesrXml(User who)
        {
            XElement users = new XElement
               ("users", new XComment("用户信息!"),
               new XElement("user",
               new XAttribute("name", who.Name),
               new XAttribute("id", who.ID),
               new XAttribute("password", who.Password))
               );
            XDocument document = new XDocument(users);

            document.Save(userlocation);
            return users;
        }

        public XElement GetArticleXml(Article article)
        {
            XElement xelement = new XElement
                ("article", new XComment("文章信息！"),
                new XAttribute("author", article.Author),
                new XAttribute("time", article.PublishDate),
                        new XElement("tile", article.Tile),
                        new XElement("body", article.Body),
                        new XElement("agree", article.Agree),
                        new XElement("disagree", article.Disagree)
                        );

            XDocument document = new XDocument(xelement);
            document.Save(articlelocation);
            return xelement;
        }

        public XElement GetCommentXml(Comment comment)
        {
             XElement xelement = new XElement
                 ("article", new XComment("评论信息！"),
                 new XAttribute("author", comment.Author),
                 new XAttribute("time", comment.PublishDate),
                        new XElement("body", comment.Body),
                        new XElement("agree", comment.Agree),
                        new XElement("disagree", comment.Disagree)
                 );

            XDocument document = new XDocument(xelement);
            document.Save(commentlocation);
            return xelement;
        }

        public XElement GetProblemXml(Problem problem)
        {
            XElement xelement = new XElement
               ("article", new XComment("求助信息！"),
                new XAttribute("author", problem.Author),
                new XAttribute("time",problem.PublishDate),
                        new XElement("body", problem.Body)
               );

            XDocument document = new XDocument(xelement);
            document.Save(problemlocation);
            return xelement;
        }

        public XElement GetSuggestXml(Suggest suggest)
        {
            XElement xelement = new XElement
                     ("article", new XComment("建议信息！"),
                     new XAttribute("author", suggest.Author),
                     new XAttribute("time", suggest.PublishDate),
                            new XElement("body", suggest.Body),
                            new XElement("agree", suggest.Agree),
                            new XElement("disagree", suggest.Disagree)
                     );

            XDocument document = new XDocument(xelement);
            document.Save(suggestlocation);
            return xelement;
        }
        
        //并在本地路径上存储！

        public void SaveXml(XElement element, string fileName)
        {
            XDocument xDocument = new XDocument(element);
            xDocument.Save(fileName);
        }


        public void GteXml()
        {
            XElement users = new XElement
               ("users", new XComment("用户信息!"),
               new XElement("user",
               new XAttribute("id", 789),
               new XAttribute("name", "gf"),
               new XAttribute("password", 3366778),
                       new XElement("article", new XAttribute("time", new DateTime(2019, 6, 18, 12, 12, 00)),
                               new XElement("tile", "2019.6.19 作业"),
                               new XElement("body", "根据用户名查找他发布的全部文章"))),
               new XElement("user",
               new XAttribute("name", "xr"),
               new XAttribute("id", 123),
               new XAttribute("password", 3861409),
                       new XElement("article", new XAttribute("time", DateTime.Now.AddDays(1)),
                                new XElement("tile", "2019.6.20 作业"),
                                new XElement("body", "统计出每个用户各发表了多少篇文章")),
                        new XElement("article", new XAttribute("time", DateTime.Now.AddDays(2)),
                                new XElement("tile", "2019.6.21 作业"),
                                new XElement("body", "查出每个用户最近发布的一篇文章"))),
               new XElement("user",
               new XAttribute("name", "zm"),
               new XAttribute("id", 321),
               new XAttribute("password", 3861223))
                );
            XDocument document = new XDocument(users);

            document.Save("C:\\Users\\meing\\Desktop\\XML.xml");
        }
    }
}
