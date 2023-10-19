using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal interface ICategoryRepository
    {
        void Add(CategoryModel categoryModel);

        void Edit(CategoryModel categoryModel);

        void Delete(int id);

        IEnumerable<CategoryModel> GetAll();
        IEnumerable<CategoryModel> GetByValue(string value);
    }
}
