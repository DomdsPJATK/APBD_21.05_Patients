using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace APBD_21._05.Model
{
    public partial class Patient
    {
        public Patient()
        {
            Prescription = new HashSet<Prescription>();
        }

        [DisplayName("Id pacjenta")] public int IdPatient { get; set; }
        [DisplayName("Imię pacjenta")] public string FirstName { get; set; }
        [DisplayName("Nazwisko pacjenta")] public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public virtual ICollection<Prescription> Prescription { get; set; }
    }
}
