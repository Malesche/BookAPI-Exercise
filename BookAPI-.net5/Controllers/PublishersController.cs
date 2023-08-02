using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Data.Models.ViewModels;
using BookAPI.Data.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublishersController : ControllerBase
    {
        private PublishersService _publishersService;

        public PublishersController(PublishersService publishersService)
        {
            _publishersService = publishersService;

        }

        [HttpPost("add-publisher")]
        public IActionResult AddBook([FromBody] PublisherVM author)
        {
            _publishersService.AddPublisher(author);
            return Ok();
        }
    }
}

