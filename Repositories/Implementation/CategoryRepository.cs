using BusinessObjects;
using DataAccessLayer;
using Repositories.Interface;

namespace Repositories.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private CategoryDAO categoryDAO;
        public CategoryRepository()
        {
            categoryDAO = new CategoryDAO();
            categoryDAO.Initiallize();
        }
        public List<Category> GetAllCategories()
        {
            return categoryDAO.GetAllCategories();
        }
    }
}
