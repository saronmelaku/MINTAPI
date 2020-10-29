using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mintapi.Model;

namespace mintapi.Data {
    public class DepartmentRepository :IStudentManagementRepository<Department>
    {
        private readonly DataContext _context;
    }
    public Task<bool> Delete(Department t)
    {
        throw new System.NotImplementedException();
    }
    public async Task<List<Department>> GetAll()
    {
        return await _Context.Department.ToListAsync();
    }
    public Task<Department> GetByID(int ID)

    {
         throw new System.NotImplementedException();   
    }
    public Task<Department> Update(Department t)
    {
         throw new System.NotImplementedException();

        }
   }



    
