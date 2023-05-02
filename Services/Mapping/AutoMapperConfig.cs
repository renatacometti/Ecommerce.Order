using AutoMapper;
using Domain.DTO;
using Domain.Entities;
using Domain.ViewModel;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<CategoriaDTO, CategoriaVM>().ReverseMap();
            CreateMap<CategoriaDTO, Categoria>().ReverseMap();
            CreateMap<CategoriaVM, CategoriaDTO>().ReverseMap();
            
        }
    }
}
