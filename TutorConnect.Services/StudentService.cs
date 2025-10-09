using TutorConnect.Core.Entities;
using TutorConnect.Core.Interfaces;

namespace TutorConnect.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public Task<Student> GetByIdAsync(int id)
        {
            return _repository.GetByIdAsync(id);
        }

        public Task RegisterAsync(Student student)
        {
            return _repository.AddAsync(student);
        }
    }
}
