using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorConnect.Core.Entities;
using TutorConnect.Core.Interfaces;


namespace TutorConnect.Data.Repositories
{   
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Student> GetByIdAsync(int id) =>
            await _context.Set<Student>().FindAsync(id);

        public async Task<IEnumerable<Student>> GetAllAsync() =>
            await _context.Set<Student>().ToListAsync();

        public async Task AddAsync(Student student)
        {
            await _context.AddAsync(student);
            await _context.SaveChangesAsync();
        }
    }
}
