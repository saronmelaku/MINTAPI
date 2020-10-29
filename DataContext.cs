using Microsoft.EntityFrameWorkCore;
using mintapi.Model;
namespace mintapi.Data {
    public class DataContext : DbContext {
        public DataContext(DbContexOptions<DataContext> options) :base(options) { }
        public DbSet<Student> Student { get; set;}
        public DbSet<Semester> Semester { get; set;}
        public DbSet<Department> Department { get; set;}
        public DbSet<Course> Course { get; set;}
        public DbSet<Faculty> Faculty { get; set;}
        public DbSet<Grade> Grade { get; set;}
    }
 

}


    
