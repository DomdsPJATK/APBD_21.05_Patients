using System;
using System.Collections.Generic;

namespace APBD_21._05.Model
{
    public partial class Prescription
    {
        public int IdPrescription { get; set; }
        public DateTime Date { get; set; }
        public DateTime DueDate { get; set; }
        public int IdPatient { get; set; }
        public int IdDoctor { get; set; }

        public virtual Doctor IdDoctorNavigation { get; set; }
        public virtual Patient IdPatientNavigation { get; set; }
        public virtual PrescriptionMedicament PrescriptionMedicament { get; set; }
    }
}
