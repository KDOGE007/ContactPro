﻿using ContactPro.Data;
using ContactPro.Models;
using ContactPro.Services.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace ContactPro.Services
{
    public class AddressBookService : IAddressBookService
    {
        //database injection
        private readonly ApplicationDbContext _context;

        //constructor
        public AddressBookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task AddContactToCategoryAsync(int categoryId, int contactId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Category>> GetContactCategoriesdAsync(int contactId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<int>> GetContactCategoryIdAsync(int contactId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId)
        {
            List<Category> categories = new List<Category>();

            try
            {
                //filter and then list them alphabettically
                categories = await _context.Categories.Where(c => c.AppUserId == userId).OrderBy(c => c.Name).ToListAsync();
            }
            catch
            {
                throw;
            }

            return categories;
        }

        public Task<bool> IsContactInCategory(int categoryId, int contactId)
        {
            throw new NotImplementedException();
        }

        public Task RemoveContactFromCategoryAsync(int categoryId, int contactId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> SearchForContacts(string searchString, string usedId)
        {
            throw new NotImplementedException();
        }
    }
}
