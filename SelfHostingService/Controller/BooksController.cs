using SelfHostingService.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostingService.Controller
{
    [RoutePrefix("book")]
    public class BooksController : ApiController
    {
        private IBookRepository _bookRepository = new BookRepository();

        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(_bookRepository.GetBooks());
        }

        [Route("Test")]
        public IHttpActionResult GetTest()
        {
            return Ok(new string[] {"test1", "test2" });
        }
    }
}
