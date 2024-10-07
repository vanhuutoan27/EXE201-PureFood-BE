using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.Core.Services
{
    public interface ISupplierService
    {
        Task<PageResult<SupplierReponse>> getAll(int page, int limit);

        Task<SupplierReponse> getSupplierById(Guid reviewid);


        Task<bool> createSupplier(CreateSupplierRequest review);

        Task<bool> updateSupplier(Guid id, CreateSupplierRequest review);

        Task<bool> deleteSupplier(Guid id);
        Task<bool> changestatus(Guid id);


    }
}
