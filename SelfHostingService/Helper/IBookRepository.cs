using SelfHostingService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostingService.Helper
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
