using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APBD_21._05.Model;

namespace APBD_21._05.Services
{

    public class PatientsServiceDataBase : IServiceDataBase
    {

        private readonly ClinicDataBaseContext _context;

        public PatientsServiceDataBase(ClinicDataBaseContext context)
        {
            _context = context;
        }

        public List<Patient> getPatients()
        {
            return _context.Patient.ToList();
        }

    }

}