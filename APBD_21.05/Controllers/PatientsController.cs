using System.Linq;
using System.Threading.Tasks;
using APBD_21._05.Services;
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

        public IActionResult PatientsTable()
        {
            return View(_service.getPatients());
        }
    }
}