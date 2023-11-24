using SistemaVenta.BLL.Servicios.Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class RolService : IRolServices
    {
        private readonly IGenericRepository<Rol> _repository;
        private readonly IMapper _mapper;

        public RolService(IGenericRepository<Rol> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<RolDTO>> Lista()
        {
            try
            {
                var listaRoles = await _repository.Consultar();
                return _mapper.Map<List<RolDTO>>(listaRoles.ToList());
            }catch (Exception ex)
            {
                throw;
            }
        }
    }
}
