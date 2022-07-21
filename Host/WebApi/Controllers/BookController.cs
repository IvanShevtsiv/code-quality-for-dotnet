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
            var x = await _bookService.Get();
            
            return x.ToList();
        }

        [HttpGet("{bookId:int:min(1)}")]
        public async Task<Book> GetByIdAsync([FromHeader]Guid id, int bookId)
        {
            var book = await _bookService.Get(id);

            return book;
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateAsync([FromBody] Book book)
        {
            await _bookService.CreateAsync(book);

            return Ok();
        }

        [HttpPut("")]
        public IActionResult PutAsync([FromBody] Book book)
        {
            _bookService.UpdateAsync(book);

            return Ok();
        }

        [HttpDelete("del")]
        public IActionResult Drop([FromHeader] Guid bookIdGuid)
        {
            _bookService.DeleteAsync(bookIdGuid);

            return Ok();
        }
    }
}
