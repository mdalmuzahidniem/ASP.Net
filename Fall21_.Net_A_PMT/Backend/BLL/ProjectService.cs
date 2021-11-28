using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.BEnt;
using AutoMapper;
using DAL;

namespace BLL
{
    public class ProjectService
    {
        public static List<ProjectModel> Get()
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Project, ProjectModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(SupervisorRepo.Get());
            return data;
        }
        public static List<ProjectModel> Get(string status)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<Project, ProjectModel>();
                c.CreateMap<User, UserModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<ProjectModel>>(SupervisorRepo.Get(status));
            return data;
        }
        public static List<AssignedProjectModel> GetRequest(string status)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<AssignedProject, AssignedProjectModel>();
                c.CreateMap<User, UserModel>();
                c.CreateMap<Project, ProjectModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<AssignedProjectModel>>(SupervisorRepo.GetRequest(status));
            return data;
        }
        /*public List<ProjectModel> Get()
        {

        }*/
        public static void Add(ProjectModel s)
        {
            var config = new MapperConfiguration(c =>
                  {
                      c.CreateMap<ProjectModel, Project>();
                  }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Project>(s);
            SupervisorRepo.Add(data);
        }
    }
}
