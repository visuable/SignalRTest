using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using SignalRTest.Models;
using SignalRTest.ViewModels;

namespace SignalRTest.Profiles
{
    public class ViewToDbRegisterModel : Profile
    {
        public ViewToDbRegisterModel()
        {
            CreateMap<ViewRegisterModel, RegisterModel>()
                .ForMember(d => d.Login, opt => opt.MapFrom(s => s.Login))
                .ForMember(d => d.Password, opt => opt.MapFrom(s => s.Password))
                .ForMember(d => d.FirstName, opt => opt.MapFrom(s => s.FirstName))
                .ForMember(d => d.LastName, opt => opt.MapFrom(s => s.LastName));
        }
    }
}
