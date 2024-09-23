using PureFood.Core.Domain.Content.Requests;
using PureFood.Core.Domain.Content.Responses;

namespace PureFood.Core.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable< CategoryReponses>> getAll();

        Task <CategoryReponses> getById(Guid id);

        Task<bool> createCategory(CreateCategoryRequest request);

        Task<bool> updateCategory(Guid id,CreateCategoryRequest request);

        Task<bool> deleteCategory(Guid id);
        


    }
}
