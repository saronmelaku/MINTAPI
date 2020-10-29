using Microsoft.AspNetCore.Mvc;
using mintapi.Data;
using mintapi.Model;
    namespace mintapi.Controllers {
      [ApiController]
      [Route("[controller]")]
     public class StudentController: ControllerBase {
        private readonly IStudentManagementRepository<Student> _repo;

        public StudentController(IStudentManagementRepository<Student> repository)
        {
            _repo = repository;
        }
        //http:/localhost:5000/Student/getallstudent
        [HttpGet("getallstudent")]
        public async Task<IActionResult> GetAllStudent() {
            var Model= await _repo.GetAll();
            return Ok(Model);
        }
    }

}
