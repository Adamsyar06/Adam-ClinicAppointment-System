using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class Doctor
{
    public string DoctorId { get; set; } = null!;

    public string DepartmentId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Email { get; set; }

    public string? PhoneNo { get; set; }

    public string? Specialization { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

    public virtual Department Department { get; set; } = null!;
}
