using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;

namespace BLL
{
    public class NewsService
    {
        public static List<NewsModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
                c.CreateMap<Catagory, CatagoryModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.Get());
            return data;
        }
       
        public static void Add(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.AddNews(data);
        }
        public static void Edit(NewsModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<NewsModel, News>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<News>(n);
            NewsRepo.EditNews(data);

        }

        public static void Delete(int id)
        {
            NewsRepo.DeleteNews(id);
        }
		public static void GetNewsByDateAndCatagory(string catagory,DateTime d)
        {
            NewsRepo.SearchByCatagoryAndDate(catagory, d);

        }

        public static List<NewsModel> GetNewsByCatagory(string catagory)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<News, NewsModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<NewsModel>>(NewsRepo.SearchByCatagory(catagory));
            return data;
        }

        public static void GetNewsByDate(DateTime date)
        {
            NewsRepo.SearchByDate(date);
        }

        
    }
}
