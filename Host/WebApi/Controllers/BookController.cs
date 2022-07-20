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

        public BookController(IBookService bs)
        {
            _bookService = bs;
        }

        [HttpGet("")]
        public async Task<List<Book>> Get()
        {
            var result = await _bookService.GetAllBooksAsync();
            return result.ToList();
        }

        [HttpGet("{bookId:int:min(1)}")]
        public async Task<Book> GetByIdAsync([FromHeader]Guid id, int bookId)
        {
            if (!_bookService.BookExists(id))
            {
                return Book.NotFound;
            }

            var book = await _bookService.GetBookAsync(id);

            return book;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateAsync([FromBody] Book book)
        {

            await _bookService.AddNewBookAsync(book);

            return Ok();
        }

        [HttpPut("")]
        public IActionResult PutAsync([FromBody] Book book)
        {

            _bookService.UpdateBookAsync(book);

            return Ok();
        }

        [HttpDelete("del")]
        public IActionResult Drop([FromHeader] Guid bookIdGuid)
        {
            if (!_bookService.BookExists(bookIdGuid))
            {
                return BadRequest($"There is no book with id {bookIdGuid}");
            }

            _bookService.DeleteBookAsync(bookIdGuid);

            return Ok();
        }
    }
}
