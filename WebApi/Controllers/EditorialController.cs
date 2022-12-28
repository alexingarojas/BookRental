using Application.Dtos.Editoriales;
using Application.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class EditorialController : Controller
    {
        private readonly IEditorialService _editorialService;

        public EditorialController(IEditorialService editorialService)
        {
            _editorialService = editorialService;
        }

        [HttpGet]
        public async Task<IEnumerable<EditorialDto>> Get()
        => await _editorialService.FindAll();

        [HttpGet("{id}")]
        public async Task<ActionResult<EditorialDto>>Get(int id) 
        {
            var response = await _editorialService.Find(id);
            //var r = await _editorialService.FindAll();
            if (response == null)return NotFound();
            return Ok(response);
        }

    }
}
