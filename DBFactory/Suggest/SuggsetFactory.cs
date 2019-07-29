using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using BLL;
using BLL.Repository;

namespace DBFactory.Suggest
{
    class SuggestFactory
    {
        public static void Create()
        {
            string folderPath = "..\\..\\..\\Data";
            string[] fileName = Directory.GetFiles(folderPath);

            for (int i= 0; i < fileName.Length; i++)
            {
                string path = fileName[i];
                string body = File.ReadAllText(path, Encoding.UTF8);
                User author = null;
                if (i%4==0)
                {
                    author = Box.Xr;
                }
                else
                {
                    author = Box.Dm;
                }
                publish(Path.GetFileName(path), body, author);
            }
        //    foreach (var item in fileName)
        //    {
        //        //读取文件
        //        string path= item;
        //        //读取文件内容
        //        string body = File.ReadAllText(item,Encoding.UTF8);
        //        User author = path.Length%2 == 0 ? Box.Xr : Box.Dm;

        //        publish(Path.GetFileName(path), body, author);
        //    }
        }

        private static BLL.Suggest publish(string title, string body, User author)
        {
            SuggestReporsitory suggestReporsitory = new SuggestReporsitory(Helper.Context);
            BLL.Suggest suggest = new BLL.Suggest
            {
                Title = title,
                Body = body,
                Author = author
            };
            suggestReporsitory.Save(suggest);
            return suggest;
        }
    }
}
