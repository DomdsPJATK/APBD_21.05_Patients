using System.Collections.Generic;
using APBD_21._05.Model;

namespace APBD_21._05.Services
{
    public interface IServiceDataBase
    {
        public List<Patient> getPatients();
        public Patient getDetails(int index);
        List<Prescription> getPatientsPrescription(int index);
        void removePatient(int index);
        void RegisterPatient(Patient patient);
    }
}