using App.Application.Interfaces;
using App.Domain.Entities;
using App.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Services
{
    public class PruebaService : IPruebaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PruebaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(Prueba prueba)
        {
            await _unitOfWork.Pruebas.CreateASync(prueba);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(object id)
        {
            await _unitOfWork.Pruebas.DeleteASync(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Prueba>> GetAllAsync()
        {
            return await _unitOfWork.Pruebas.GetAllAsync();
        }

        public async Task<Prueba> GetByIdAsync(object id)
        {
            return await _unitOfWork.Pruebas.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Prueba prueba)
        {
            await _unitOfWork.Pruebas.UpdateASync(prueba);
            await _unitOfWork.CommitAsync();
        }
    }
}
