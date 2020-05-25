using System.Collections.Generic;
using System.Threading.Tasks;
using APBD_21._05.Model;
using Microsoft.AspNetCore.Mvc;

namespace APBD_21._05.Services
{
    public interface IServiceDataBase
    {
        public List<Patient> getPatients();
        public string getDetails(int index);
    }
}