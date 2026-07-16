using Module.Customers.Application.DTOs;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Application.Interfaces
{
    public interface IClienteService
    {
        Task<ClienteDTO?> GetByIdAsync(long Id);
        Task<List<ClienteDTO>> GetAllAsync();
    }
}
