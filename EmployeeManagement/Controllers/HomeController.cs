using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public JsonResult Index()
        {
            return Json(_employeeRepository.GetEmployee(1));
        }

        //public ObjectResult Details()
        //{
        //    return new ObjectResult(_employeeRepository.GetEmployee(1));
        //}
        
        public ViewResult Details()
        {
            return View(_employeeRepository.GetEmployee(1));
        }

        public ViewResult CustomView()
        {
            //return View("Test"); // using view name
           // return View("CustomViews/Test.cshtml");  // using absolute path
            return View("../../CustomViews/Test"); // relative path
        }
    }
}
