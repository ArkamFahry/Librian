using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace librian_desktop.Data.MainDb.Categories
{
    public class CategoryRepo : ICategoryRepo
    {
        public async Task<bool> CreateCategoryAsync(Category category)
        {
            category.Id = Guid.NewGuid().ToString();
            category.CreatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            await lbContext.Categories.AddAsync(category);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UpdateCategoryAsync(Category category)
        {
            category.UpdatedAt = DateTime.Now;

            await using var lbContext = new LibrianContext();
            lbContext.Categories.Update(category);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteCategoryAsync(Category category)
        {
            await using var lbContext = new LibrianContext();
            lbContext.Categories.Remove(category);
            await lbContext.SaveChangesAsync();

            return true;
        }

        public async Task<Category?> GetCategoryByIdAsync(string id)
        {
            await using var lbContext = new LibrianContext();
            var category = await lbContext.Categories.FirstOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Category?> GetCategoryByNameAsync(string name)
        {
            await using var lbContext = new LibrianContext();
            var category = await lbContext.Categories.FirstOrDefaultAsync(c => c.Name == name);
            return category;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        { 
            await using var lbContext = new LibrianContext();
            var categories = lbContext.Categories.ToList();
            return categories;
        }
    }
}
