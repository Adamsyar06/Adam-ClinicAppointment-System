using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class Patient
{
    public string PatientId { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public string? Gender { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? IcNumber { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public virtual ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
