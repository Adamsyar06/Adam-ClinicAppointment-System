using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class Prescription
{
    public string PrescriptionId { get; set; } = null!;

    public string AppointmentId { get; set; } = null!;

    public string? DoctorNotes { get; set; }

    public virtual Appointment Appointment { get; set; } = null!;

    public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; } = new List<PrescriptionDetail>();
}
