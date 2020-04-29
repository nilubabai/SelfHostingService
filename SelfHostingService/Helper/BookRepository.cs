using SelfHostingService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostingService.Helper
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            List<Book> data;
            using (EmployeeDBEntities entity = new EmployeeDBEntities()) 
            {
                data = entity.Books.ToList();
            }

            return data;
        }
    }
}
