using AutoMapper;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public SupplierService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }
    }
}
