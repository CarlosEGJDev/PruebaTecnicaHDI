using Module.Customers.Application.DTOs;
using Module.Customers.Application.Interfaces;
using Module.Customers.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Customers.Application.Services
{
    public class ClienteService(IClienteRepository clienteRepository) : IClienteService
    {

        private readonly IClienteRepository _clienteRepository = clienteRepository;

        public async Task<List<ClienteDTO>> GetAllAsync()
        {
            var data = await _clienteRepository.GetAllAsync();
            var listar = new List<ClienteDTO>();

            foreach(var item in data)
            {
                listar.Add(new ClienteDTO
                {
                    Id = item.Id,
                    Nombre = item.Nombre,
                    Email = item.Email
                });
            }

            return listar;
        }

        public async Task<ClienteDTO?> GetByIdAsync(long Id)
        {
            var data = await _clienteRepository.GetByIdAsync(Id);

            if (data == null)
                return null;

            var respuesta = new ClienteDTO
            {
                Id = data.Id,
                Nombre = data.Nombre,
                Email = data.Email
            };

            return respuesta;
        }
    }
}
