using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SignalRTest.Models;
using SignalRTest.ViewModels;

namespace SignalRTest.Profiles
{
    public class ViewToDbLoginModel : Profile
    {
        public ViewToDbLoginModel()
        {
            CreateMap<ViewLoginModel, LoginModel>()
                .ForMember(d => d.Login, opt => opt.MapFrom(s => s.Login))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => s.Password));
        }
    }
}
