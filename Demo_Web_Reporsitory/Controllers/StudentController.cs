using Demo_Web_Reporsitory.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_Web_Reporsitory.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _studentRepository;

        public StudentController()
        {
            _studentRepository = new StudentRepository(new StudentDBContext());
        }

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            var model = _studentRepository.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(STUDENT model)
        {
            if(ModelState.IsValid)
            {
                _studentRepository.insert(model);
                _studentRepository.save();
                return RedirectToAction("Index", "Student");
            }
            return View();
        }

        [HttpGet]
        public ActionResult EditStudent(int id)
        {
            STUDENT student = _studentRepository.GetByID(id);
            return View(student);
        }

        [HttpPost]
        public ActionResult EditStudent(STUDENT model)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.update(model);
                _studentRepository.save();
                return RedirectToAction("Index", "Student");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult DeleteEmployee(int EmployeeId)
        {
           STUDENT model = _studentRepository.GetByID(EmployeeId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Delete(int EmployeeID)
        {
            _studentRepository.delete(EmployeeID);
            _studentRepository.save();
            return RedirectToAction("Index", "Employee");
        }
    }
}