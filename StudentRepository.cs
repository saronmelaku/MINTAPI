using System.Collections.Generic;
using System.Threading.Tasks;
using mintapi.Model;


namespace mintapi.Data
{
    public class StudentRepository :IStudentManagementRepository<Student>
     {
         private readonly DataContect _Context;
         public Task<bool> Delete(Student t)
         {
             throw new System.NotImplementedException();

         }
         public async Task<List<Student>> GetAll()
         {
             return await _context.student.ToListAsynic();
             {
                 
             }

         }
         public Task<Student> Update(Student t)
         {
             throw new System.NotImplementedException();
         }

    }
    
}