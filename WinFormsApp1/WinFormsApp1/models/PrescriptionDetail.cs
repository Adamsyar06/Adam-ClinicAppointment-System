using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class PrescriptionDetail
{
    public string PrescriptionDetailId { get; set; } = null!;

    public string PrescriptionId { get; set; } = null!;

    public string MedicineId { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Dosage { get; set; }

    public virtual Medicine Medicine { get; set; } = null!;

    public virtual Prescription Prescription { get; set; } = null!;
}
