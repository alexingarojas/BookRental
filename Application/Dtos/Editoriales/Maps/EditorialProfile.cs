using AutoMapper;
using Domain;
using System;


namespace Application.Dtos.Editoriales.Maps
{
    public class EditorialProfile : Profile    
    {
        public EditorialProfile()
        {
            CreateMap<Editorial, EditorialDto>();
        }
    }
}
