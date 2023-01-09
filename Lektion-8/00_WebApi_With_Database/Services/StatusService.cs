using _00_WebApi_With_Database.Contexts;
using _00_WebApi_With_Database.Models;
using _00_WebApi_With_Database.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _00_WebApi_With_Database.Services
{
    public class StatusService
    {
        private readonly DataContext _context;

        public StatusService(DataContext context)
        {
            _context = context;
        }


        public async Task<bool> ItemExistsAsync(string name)
        {
            if (await _context.Statuses.AnyAsync(x => x.Name == name))
                return true;

            return false;
        }



        public async Task<bool> CreateAsync(StatusRequest req)
        {
            if (string.IsNullOrWhiteSpace(req.Name))
                return false;

            try
            {
                _context.Add(new StatusEntity { Name = req.Name });
                await _context.SaveChangesAsync();
                return true;
            } 
            catch (Exception ex){ Debug.WriteLine(ex.Message); }
            return false;
        }

        public async Task<IEnumerable<Status>> GetAllAsync()
        {
            try
            {
                var result = await _context.Statuses.ToListAsync();
                
                var items = new List<Status>();
                foreach (var item in result)
                    items.Add(new Status { Id = item.Id, Name = item.Name });

                return items;

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new List<Status>();
        }



    }
}
