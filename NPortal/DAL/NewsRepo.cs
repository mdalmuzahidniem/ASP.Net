using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsRepo
    {
        static demoEntities db;
        static NewsRepo()
        {
            db = new demoEntities();
        }
        public static List<News> Get()
        {
            return db.News.ToList();
        }
        public static News SearchByCatagory(string catagoryName)
        {
            var a=db.Catagories.First(e => e.Catagory_name == catagoryName);
           
            return db.News.First(e => e.Catagory_id == a.Id);
        }

        public static News SearchByDate(DateTime d)
        {
            return db.News.First(e => e.Publish_date == d);
        }
        public static News SearchByCatagoryAndDate(string catagory,DateTime d)
        {
            var a = db.Catagories.FirstOrDefault(e => e.Catagory_name == catagory);
            return db.News.First(e => e.Catagory_id == a.Id && e.Publish_date==d);
           
        }
        public static void AddNews(News a)
        {
            db.News.Add(a);
            db.SaveChanges();
        }
		public static void DeleteNews(int id)
        {
            var n = db.News.FirstOrDefault(e => e.Id == id);
            db.News.Remove(n);
            db.SaveChanges();
        }
        public static void EditNews(News n)
        {
            var ds = db.News.FirstOrDefault(e => e.Id == n.Id);
            db.Entry(ds).CurrentValues.SetValues(n);
            db.SaveChanges();
        }
        
    }
}
