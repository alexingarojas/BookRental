﻿using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using AutoMapper;
using Infrastructure.Repositories.Abstractions;
using System;


namespace Application.Services.Implementations
{
    public class EditorialService : IEditorialService
    {
        private readonly IMapper _mapper;
        private readonly IEditorialRepository _editorialRepository;
        public EditorialService(IMapper mapper, IEditorialRepository editorialRepository)
        {
            _mapper = mapper;
            _editorialRepository = editorialRepository;
        }
        public async Task<IList<EditorialDto>> FindAll()
        {
            var response = await _editorialRepository.findAll();

            return _mapper.Map<IList<EditorialDto>>(response);
        }
    }
}