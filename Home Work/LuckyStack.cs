using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    //class LuckyStack
    //{
    //}

    //class User//用户
    //{
    //    public int ID { get; set; }
    //}

    //class Author : User//作者
    //{
    //    public string Name { get; set; }
    //    public Article Articles { get; set; }

    //}

    //class Article : Author//文章
    //{
    //    public string Tile { get; set; }//标题
    //    public string Boyd { get; set; }//正文
    //    public int Agree { get; set; }//赞成数
    //    public int Disagree { get; set; }//反对数
    //    public string ComName { get; set; }//评论者
    //    public string Comment { get; set; }//评论内容
    //}

    //class Logger //log记录
    //{
    //    public void GetPublishLog(Article article)//文章log
    //    {
    //        Console.WriteLine("{0}于{1}发布了一篇文章:{2}", article.Name, DateTime.UtcNow, article.Tile);
    //       // Console.WriteLine("赞：{0} 踩：{1} 评论{2} ", article.Agree, article.Disagree, article.Comment);
    //        //Console.WriteLine("{0}评论了{1}:{2}:", article.ComName, article.Tile, article.Comment);

    //    }

    //    public void GetProblemLog(Article article)//求助log
    //    {
    //        Console.WriteLine("{0}于{1}发布了一个求助:{2}", article.Name, DateTime.UtcNow, article.Tile);
    //       // Console.WriteLine("赞：{0} 踩：{1} ", article.Agree, article.Disagree);
    //        //Console.WriteLine("{0}评论了{1}：{2}", article.ComName, article.Tile, article.Comment);
    //    }

    //    public void GetSuggestLog(Article article)//建议log
    //    {
    //        Console.WriteLine("{0}于{1}提出了一个建议:{2}", article.Name, DateTime.UtcNow, article.Tile);
    //        //Console.WriteLine("赞：{0} 踩：{1} ", article.Agree, article.Disagree);
    //        //Console.WriteLine("{0}评论了{1}：{2}", article.ComName, article.Tile, article.Comment);
    //    }
    //}

    //class Function //功能
    //{
    //    public Article Publish(Author author, Action<Article> getlog)//发布文章
    //    {

    //        Article article = new Article();
    //        article.Name = author.Name;
    //        article.Tile = "这是一篇文章";
    //        Console.WriteLine("***************************************************");
    //        article.Boyd = "文章内容...........";
    //        article.Agree = 0;
    //        article.Disagree = 0;
    //        article.ComName = "";
    //        article.Comment = "";
    //        getlog(article);//打印log
    //        return article;
    //    }

    //    public Article PushProblem(Author author, Action<Article> getlog)//发布求助
    //    {
    //        Article problem = new Article();
    //        problem.Name = author.Name;
    //        problem.Tile = "这是一个求助";
    //        problem.Boyd = "求助内容......";
    //        problem.ComName = "";
    //        problem.Comment = "";
    //        getlog(problem);//打印log
    //        return problem;
    //    }

    //    public Article PushSuggest(Author author, Action<Article> getlog) //意见反馈
    //    {
    //        Article suggest = new Article();
    //        suggest.Name = author.Name;
    //        suggest.Tile = "这是一条建议";
    //        suggest.Boyd = "建议内容.......";
    //        suggest.Agree = 0;
    //        suggest.Disagree = 0;
    //        suggest.ComName = "";
    //        suggest.Comment = "";
    //        getlog(suggest);//打印log
    //        return suggest;
    //    }

    //    public Article PushTile(Article article)//修改标题
    //    {
    //        article.Tile = "修改后的标题......";
    //        return article;
    //    }

    //    public Article PushBody(Article article)//修改正文
    //    {
    //        article.Boyd = "修该后的正文......";
    //        return article;
    //    }

    //    public Article Comment(Author author, Article article,string comment)//发布一个评论
    //    {
    //        article.ComName = author.Name;
    //        article.Comment = comment;
    //        return article;
    //    }

    //    public Article GetAgree(Article article) //赞
    //    {
    //        article.Agree++;
    //        return article;
    //    }

    //    public Article GetDisagtee(Article article)//踩
    //    {
    //        article.Disagree++;
    //        return article;
    //    }
    //}
}
