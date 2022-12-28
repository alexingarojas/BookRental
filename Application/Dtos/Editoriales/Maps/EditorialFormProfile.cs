using AutoMapper;
using Domain;
using System;


namespace Application.Dtos.Editoriales.Maps
{
    public class EditorialFormProfile:Profile
    {
        public EditorialFormProfile()
        {
            CreateMap<EditorialFormDto,Editorial>();
        }
    }
}
