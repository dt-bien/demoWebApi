using DemoApp.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.DAL
{
    public abstract class DataAccess
    {
        public AppDbContext context = new AppDbContext();
        //public abstract string GetAll();
        //public abstract string GetById(string id);
        //public abstract int Create(string data);
        //public abstract int Update(string id, string data);
        //public abstract int Delete(string id);
    }
}