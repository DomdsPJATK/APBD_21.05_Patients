using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APBD_21._05.Model;
using APBD_21._05.Views;

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

        public Patient getDetails(int index)
        {
            var res = _context.Patient.FirstOrDefault(e => e.IdPatient == index);
            if (res == null) return null;

            return res;
        }

        public List<Prescription> getPatientsPrescription(int index)
        {
            return _context.Prescription.Where(prescription => prescription.IdPatient == index).ToList();
        }

        public void removePatient(int index)
        {
            var toDelete = _context.Patient.FirstOrDefault(p => p.IdPatient == index);
            if(toDelete == null) return;
            _context.Patient.Remove(toDelete);
            _context.SaveChanges();
        }

        public void RegisterPatient(Patient patient)
        {
            _context.Add(new Patient()
            {
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                Birthdate = patient.Birthdate
            });
            _context.SaveChanges();
        }
    }

}