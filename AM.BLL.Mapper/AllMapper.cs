
using AM.DM.DAL;
using AM.DM.User;
using ArticleManagement.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AM.BLL.Mapper
{
    public class AllMapper : Profile
    {
        public AllMapper()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
