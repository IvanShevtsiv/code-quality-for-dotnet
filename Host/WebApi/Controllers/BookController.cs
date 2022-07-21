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
    public List<Book> Get()
    {
      var books = _bookService.Get();
      return books.ToList();
    }

    [HttpGet("{bookId:guid}")]
    public Book GetById([FromHeader] Guid bookId)
    {
      var book = _bookService.Get(bookId);
      return book;
    }

    [HttpPost("")]
    public IActionResult Create([FromBody] Book book)
    {
      _bookService.Create(book);
      return CreatedAtAction(nameof(Get), book.Id, book);
    }

    [HttpPut("")]
    public IActionResult Put([FromBody] Book book)
    {
      _bookService.Update(book);
      return Ok(book);
    }

    [HttpDelete("")]
    public IActionResult Delete([FromHeader] Guid bookId)
    {
      _bookService.Delete(bookId);
      return NotFound(bookId);
    }
  }
}