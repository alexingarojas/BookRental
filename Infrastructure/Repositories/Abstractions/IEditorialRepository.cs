using Domain;
using System;


namespace Infrastructure.Repositories.Abstractions
{
    public interface IEditorialRepository
    {
        Task<IList<Editorial>> findAll();
        Task<Editorial?> Edit(int id,Editorial entity);
        Task<Editorial> Create(Editorial entity);
        Task<Editorial?> EnableOrDisable(int id);
        Task<Editorial?> Find(int id);
    }
}
