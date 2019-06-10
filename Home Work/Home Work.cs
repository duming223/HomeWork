using System;

namespace Home_Work
{
    class Program
    {
        static void Main(string[] args)
        {
            Function function = new Function();

            Logger logger = new Logger();

            Action<Article> getpublishlog = new Action<Article>(logger.GetPublishLog);
            Action<Article> getproblemlog = new Action<Article>(logger.GetProblemLog);
            Action<Article> getsuggestlog = new Action<Article>(logger.GetSuggestLog);

            Author zm = new Author() { ID = 369, Name = "左明" };
            Author xr = new Author() { ID = 223, Name = "行人" };
            Author lr = new Author() { ID = 258, Name = "路人" };

            //发布一篇文章
            Article article = function.Publish(xr, getpublishlog);

            //发布一篇求助
            //Article problem = function.PushProblem(zm,getproblemlog);

            //提出一个建议
            // Article suggest = function.PushSuggest(lr, getsuggestlog);

            //评论一篇文章
            function.Comment(lr, article, "#%%$^#$@");


            //Console.WriteLine("赞：{0} 踩：{1}  ", article.Agree, article.Disagree);
            Console.WriteLine("{0}评论了：{1}:{2}:", article.ComName, article.Tile, article.Comment);


            //IArithmetc arithmetc = new Add();
            //double x = arithmetc.Add(1, 3);
            //Console.WriteLine(x);

            //Number number = new Number();
            //int x = number.Add(1, 3);
            //Console.WriteLine(x);
        }
    }

    class Example
    {

    }
}
