using BookLibrary.Models;
using BookLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BookController : ControllerBase
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

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetByIdAsync(Guid id)
        {
            try
            {
                return await _bookService.GetBookByIdAsync(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create")]
        public IActionResult CreateAsync([FromBody] Book book)
        {
            _bookService.CreateBook(book);

            return Ok();
        }

        [HttpPut("update")]
        public IActionResult UpdateBook([FromBody] Book book)
        {
            try
            {
                _bookService.UpdateBook(book);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeleteBook(Guid id)
        {
            try
            {
                await _bookService.DeleteBookAsync(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return Ok();
        }
    }
}
