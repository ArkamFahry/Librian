using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librian_desktop.Data.MainDb.Categories
{
    public interface ICategoryRepo
    {
        Task<bool> CreateCategoryAsync(Category  category);

        Task<bool> UpdateCategoryAsync(Category category);

        Task<bool> DeleteCategoryAsync(Category category);

        Task<Category?> GetCategoryByIdAsync(string id);

        Task<Category?> GetCategoryByNameAsync(string name);

        Task<IEnumerable<Category>> GetAllCategoriesAsync();
    }
}
