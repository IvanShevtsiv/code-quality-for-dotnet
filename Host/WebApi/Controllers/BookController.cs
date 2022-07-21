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

        [HttpGet("")]
        public async Task<IEnumerable<Book>> Get() 
        {
            return await _bookService.GetAsync();
        }

        [HttpGet("{bookId:int:min(1)}")]
        public async Task<Book> GetByIdAsync([FromHeader] Guid id)
        {
            return await _bookService.GetAsync(id);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateAsync([FromBody] Book book)
        {
            await _bookService.CreateAsync(book);

            return Ok();
        }

        [HttpPut("")]
        public async Task<IActionResult> PutAsync([FromBody] Book book)
        {
            await _bookService.UpdateAsync(book);

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
