using Host.Core.Entities;
using Host.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Host.WebApi.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public List<Book> GetBooks()
        {
            return _bookService.GetBooks().ToList();
        }

        [HttpGet("{bookId:int:min(1)}")]
        public async Task<IActionResult> GetBookByIdAsync([FromHeader]Guid bookId)
        {
            Book book = null;
            try
            {
                book = await _bookService.GetBookByIdAsync(bookId);
            }
            catch(Exception exception)
            {
                return BadRequest(exception.Message);
            }

            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook([FromBody] Book book)
        {
            _bookService.CreateBook(book);

            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBook([FromBody] Book book)
        {
            _bookService.UpdateBook(book);

            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteBook([FromHeader] Guid bookId)
        {
            _bookService.DeleteBook(bookId);

            return Ok();
        }
    }
}
