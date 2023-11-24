using AutoMapper;
using SistemaVenta.BLL.Servicios.Contrato;
using SistemaVenta.DAL.Repositorios.Contrato;
using SistemaVenta.DTO;
using SistemaVenta.Model;

namespace SistemaVenta.BLL.Servicios
{
    public class CategoriaService : ICategoriaService
    {
        private readonly IGenericRepository<Categoria> _repository;
        private readonly IMapper _mapper;

        public CategoriaService(IGenericRepository<Categoria> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<CategoriaDTO>> Lista()
        {
            try
            {
                var listaCategorias = await _repository.Consultar();
                return _mapper.Map<List<CategoriaDTO>>(listaCategorias.ToList());
            }catch (Exception ex)
            {
                throw;
            }
        }
    }
}
