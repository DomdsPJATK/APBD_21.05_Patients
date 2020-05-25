using System.Collections.Generic;
using APBD_21._05.Model;

namespace APBD_21._05.ViewModel
{
    public class ShowDetailsModel
    {
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Prescription> Prescriptions { get; set; }
        public Patient PatientDetails { get; set; }
    }
}