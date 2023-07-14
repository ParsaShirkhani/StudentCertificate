using WTFFirstProject.Interfaces;
using WTFFirstProject.Models;

namespace WTFFirstProject.Services
{
    public class StudentService : IStudentService
    {
        public List<Student> Students = new List<Student>();
        public List<Student> CertificateStudents = new List<Student>();

        public string GetCertificate(int id)
        {
            #region Add a temporary student

            Student TemporaryStudent = new Student()
            {
                Id = 1,
                FullName = "Test",
                StudentCode = "123456",
                RegisteredCourse = "Asp.NetCore",
                PhoneNumber = "09123456789"
            };

            Students.Add(TemporaryStudent);

            #endregion

            try
            {
                Student student = Students.First(student => student.Id == id);
                CertificateStudents.Add(student);
                return "true";
            }
            catch (Exception ex)
            {
                return "false" + ex;
                throw;
            }
        }
    }
}
