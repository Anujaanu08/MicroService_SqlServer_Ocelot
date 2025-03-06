﻿using BooksService.NewFolder;

namespace BooksService.IService
{
    public interface IBookService
    {
        Task<IEnumerable<Books>> GetAllBooksAsync();
        Task<Books?> GetBookByIdAsync(int id);
        Task AddBookAsync(Books book);
    }
}
