using AutoMapper;
using Microsoft.VisualBasic;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public CategoryService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> createCategory(CreateCategoryRequest request)
        {
            var newCategory = new Category
            {
                CategoryId = Guid.NewGuid(),
                CategoryName = request.CategoryName,
                CreatedAt = DateTime.Now,
                Description = request.Description,
            };

            _repositoryManager.CategoryRepository.Add(newCategory);
            await _repositoryManager.SaveAsync();

            return true;
        }

        public async Task<bool> deleteCategory(Guid id)
        {
            var getCategory = await _repositoryManager.CategoryRepository.GetByIdAsync(id);
            if (getCategory == null)
            {
                throw new Exception("Category not found.");
            }
            _repositoryManager.CategoryRepository.Remove(getCategory);

            await _repositoryManager.SaveAsync();
            return true;

        }

        public async Task<IEnumerable<CategoryReponses>> getAll()
        {
            var categoryRepository = await _repositoryManager.CategoryRepository.GetAllAsync();

            return _mapper.Map<IEnumerable<CategoryReponses>>(categoryRepository);

        }

        public async Task<CategoryReponses> getById(Guid id)
        {
            var categoryRepository = await _repositoryManager.CategoryRepository.GetByIdAsync(id);
            return _mapper.Map<CategoryReponses>(categoryRepository);
        }

        public async Task<bool> updateCategory(Guid id, CreateCategoryRequest request)
        {
            var getCategory = await _repositoryManager.CategoryRepository.GetByIdAsync(id);
            if (getCategory == null)
            {
                throw new Exception("Category not found.");
            }
            getCategory.UpdatedAt = DateTime.Now;
            getCategory.Description = request.Description;
            getCategory.CategoryName = request.CategoryName;
            _repositoryManager.CategoryRepository.Update(getCategory);
            await _repositoryManager.SaveAsync();
            return true;


        }
    }
}
