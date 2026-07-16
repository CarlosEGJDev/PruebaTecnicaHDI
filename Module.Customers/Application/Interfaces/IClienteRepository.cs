using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Application.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente?> GetByIdAsync(long Id);
        Task<List<Cliente>> GetAllAsync();   
    }
}
