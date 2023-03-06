using App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Interfaces
{
    public interface IPruebaService
    {
        Task CreateAsync(Prueba prueba);
        Task DeleteAsync(Object id);
        Task<IEnumerable<Prueba>> GetAllAsync();
        Task<Prueba> GetByIdAsync(object id);
        Task UpdateAsync(Prueba prueba);
    }
}
