using System;


namespace Application.Dtos.Editoriales
{
    public class EditorialDto:EditorialFormDto
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
    }
}
