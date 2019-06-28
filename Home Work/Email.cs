using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace HomeWork
{
    static class Email
    {
        private static List<string> _ls;
        private static string[] arr = null;
        private static List<string> _rs;
        private static string _st;
        private static List<string> _result;

        private static string path = @"C:\Users\meing\source\repos\HomeWork\Home Work\Repository";
        private static string path1 = path + @"\Test.txt";
        private static string _spath = path + @"\ResultTest.txt";

        public static void Write(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter writer = File.CreateText(path)) { }
            }
        }

        public static IList<string> GetFormTxt()
        {
            _ls = File.ReadAllLines(path1).ToList();
            return _ls;
        }

        public static void Filter()
        {

            var x = from s in _ls
                    select s;
            foreach (var item in x)
            {
                _st += item;
            }
            arr = _st.Split(';', ' ');

        }


        public static void SaveInGropup()
        {
            const int pageSize = 30;
            int pageNum = 0;

            while (pageSize * pageNum > arr.Length)
            {
                var x = arr.Skip(pageNum * pageSize).Take(pageSize);
  
                _result.Add(x.ToString());

                pageNum++;
            }

            File.WriteAllLines(_spath,_result);
        }

        public static void Action()
        {
            GetFormTxt();
            Filter();
            SaveInGropup();
        }

    }
}
