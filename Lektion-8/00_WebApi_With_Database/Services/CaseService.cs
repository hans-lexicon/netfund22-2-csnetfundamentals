using _00_WebApi_With_Database.Contexts;
using _00_WebApi_With_Database.Models.Entities;
using _00_WebApi_With_Database.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _00_WebApi_With_Database.Services
{
    public class CaseService
    {
        private readonly DataContext _context;

        public CaseService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> CreateAsync(CaseRequest req)
        {
            if (string.IsNullOrWhiteSpace(req.Email) || string.IsNullOrWhiteSpace(req.Subject) || string.IsNullOrWhiteSpace(req.Message))
                return -1;

            try
            {
                var _caseEntity = new CaseEntity { Email = req.Email, Subject = req.Subject, Message = req.Message, StatusId = 1 };
                _context.Add(_caseEntity);
                await _context.SaveChangesAsync();
                return _caseEntity.Id;
            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return -1;
        }

        public async Task<IEnumerable<Case>> GetAllAsync()
        {
            try
            {
                var result = await _context.Cases.Include(x => x.Status).ToListAsync();

                var items = new List<Case>();
                foreach (var item in result)
                    items.Add(new Case
                    {
                        Id = item.Id,
                        Email = item.Email,
                        Subject = item.Subject,
                        Message = item.Message,
                        Created = item.Created,
                        Modified = item.Modified,
                        Status = item.Status.Name
                    });

                return items;

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return new List<Case>();
        }

        public async Task<Case> GetAsync(int id)
        {
            try
            {
                var item = await _context.Cases.Include(x => x.Status).FirstOrDefaultAsync(x => x.Id == id);
                if (item == null)
                    return null!;

                return new Case
                {
                    Id = item.Id,
                    Email = item.Email,
                    Subject = item.Subject,
                    Message = item.Message,
                    Created = item.Created,
                    Modified = item.Modified,
                    Status = item.Status.Name
                };

            }
            catch (Exception ex) { Debug.WriteLine(ex.Message); }
            return null!;
        }

    }
}
