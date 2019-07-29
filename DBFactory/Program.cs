using BLL.Repository;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFacade db = new SQLContext().Database;
            db.EnsureDeleted();
            db.EnsureCreated();

            Suggest.SuggestFactory.Create();

            Console.WriteLine("AllRight");
        }
    }
}
