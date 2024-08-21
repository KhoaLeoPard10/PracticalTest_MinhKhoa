using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryServices
    {
        private BookCategoryRepository _repo = new();
        public List<BookCategory> GetAllCategories()
        {
            return _repo.GetCategories();
        }
    }
}
