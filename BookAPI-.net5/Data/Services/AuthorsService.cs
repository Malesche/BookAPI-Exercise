using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Data.Models;
using BookAPI.Data.Models.ViewModels;

namespace BookAPI.Data.Services
{
	public class AuthorsService
	{
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorVM book)
        {
            var _author = new Author()
            {
                FullName = book.FullName
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}

