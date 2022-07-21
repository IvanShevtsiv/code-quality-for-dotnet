using Host.Core.Entities;
using Host.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Host.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("{bookId:guid}")]
        public IActionResult GetBookById(Guid bookId)
        {
            var book = _bookService.GetById(bookId);

            return book == null
              ? NotFound()
              : Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            var newBook = _bookService.Create(book);

            return CreatedAtAction(nameof(CreateBook), newBook);
        }

        [HttpPut]
        public IActionResult UpdateBook(Book book)
        {
            _bookService.Update(book);

            return Ok();
        }

        [HttpDelete("{bookId:guid}")]
        public IActionResult DeleteBook(Guid bookId)
        {
            _bookService.Delete(bookId);

            return NoContent();
        }
    }
}
