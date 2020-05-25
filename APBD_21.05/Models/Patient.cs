using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using APBD_19._03_CW3.DAL;
using Newtonsoft.Json;

namespace APBD_21._05.Model
{
    public partial class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        [DisplayName("Id")] public int IdPatient { get; set; }
        [Required] [DisplayName("Imię")] public string FirstName { get; set; }
        [Required] [DisplayName("Nazwisko")] public string LastName { get; set; }
        [Required] [DisplayName("Data urodzenia")] public DateTime Birthdate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}