using EmployeeDataWebApi.Interfaces;
using EmployeeDataWebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDataWebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _repo;
        public EmployeeController(IEmployee repo)
        {
            _repo = repo;
        }

        // GET: api/employee>
        [HttpGet]
        public ActionResult<IEnumerable<Employee>>Get()
        {
            var employees = _repo.GetEmployeeDetails();
            return Ok(employees);
        }

        // GET api/employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> Get(int id)
        {
            var employees = await Task.FromResult(_repo.GetEmployeeDetails(id));
            if (employees == null)
            {
                return NotFound();
            }
            return employees;
        }

        // POST api/employee
        public async Task<ActionResult> AddEmployee([FromBody] Employee employee)
        {
            if(employee == null)
            {
                return NotFound("Getting Null for Employee");
            }
            _repo.AddEmployee(employee);
            return Ok("Employee Added");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEmployee([FromBody] Employee employee)
        {
            if(employee == null)
            {
                return NotFound("Getting Null for Employee");
            }
            _repo.UpdateEmployee(employee);
            return Ok("Employee details Updated");
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEmployee(int? id)
        {
            if(id == null)
            {
                return NotFound("Getting Null for Employee");
            }
            _repo.DeleteEmployee(id);
            return Ok("Employee Deleted");
        }

    }
}
