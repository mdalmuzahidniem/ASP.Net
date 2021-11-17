﻿using BLL;
using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NewsPortal.Controllers
{
    public class NewsController : ApiController
    {
        
        [Route("api/News")]
        [HttpGet]
        public List<NewsModel> GetAll()
        {
            return NewsService.Get();
        }

        [Route("api/News/Create")]
        [HttpPost]
        public void Add(NewsModel n)
        {
            NewsService.Add(n);
        }
        [Route("api/News/Edit/{id}")]
        [HttpPost]
        public void Edit(NewsModel n)
        {
            NewsService.Edit(n);
        }
        [Route("api/News/Delete/{id}")]
    
        public void Delete( [FromUri] int id)
        {
            NewsService.Delete(id);
            //return id;
        }

        [Route("api/News/{cata}")]
        [HttpGet]
        public List<NewsModel> GetNewsByCata([FromUri] string cata)
        {
            return NewsService.GetNewsByCatagory(cata);

        }
    }
}
