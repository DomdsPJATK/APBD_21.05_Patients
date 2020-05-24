using System;
using System.Collections.Generic;

namespace APBD_21._05.Model
{
    public partial class PrescriptionMedicament
    {
        public int IdPrescription { get; set; }
        public int IdMecidament { get; set; }
        public int Dose { get; set; }
        public string Details { get; set; }

        public virtual Medicament IdMecidamentNavigation { get; set; }
        public virtual Prescription IdPrescriptionNavigation { get; set; }
    }
}
