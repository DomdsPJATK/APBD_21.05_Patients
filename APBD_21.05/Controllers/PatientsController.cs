using System;
using System.Linq;
using System.Threading.Tasks;
using APBD_21._05.Model;
using APBD_21._05.Services;
using APBD_21._05.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace APBD_21._05.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IServiceDataBase _service;

        public PatientsController(IServiceDataBase service)
        {
            _service = service;
        }

        // GET
        public IActionResult Index()
        {
            // return new EmptyResult();
            return View();
        }

        public IActionResult PatientsList()
        {
            return View(_service.getPatients());
        }

        public IActionResult ShowDetails(int index)
        {
            return View(new ShowDetailsModel()
            {
                PatientDetails = _service.getDetails(index),
                Patients = _service.getPatients(),
                Prescriptions = _service.getPatientsPrescription(index)
            });
        }

        public IActionResult RemovePatient(int index)
        {
            _service.removePatient(index);
            return RedirectToAction("PatientsList");
        }
        
        public IActionResult RegisterPatient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterPatient(Patient patient)
        {
            if (!ModelState.IsValid) return View(patient);
            _service.RegisterPatient(patient);
            return RedirectToAction("Index");
        }
        
    }
}