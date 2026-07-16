using Microsoft.EntityFrameworkCore;
using Module.Customers.Application.Interfaces;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Infraestructure.Repositories
{
    public class ClienteRepository(CustomerDBContext context) : IClienteRepository
    {
        public async Task<List<Cliente>> GetAllAsync()
        {
            return await context.Clientes.ToListAsync();
        }
        public async Task<Cliente?> GetByIdAsync(long Id)
        {
            return await context.Clientes.FirstOrDefaultAsync(c => c.Id == Id);
        }
    }
}
