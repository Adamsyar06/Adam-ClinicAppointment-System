using System;
using System.Collections.Generic;

namespace WinFormsApp1.models;

public partial class Medicine
{
    public string MedicineId { get; set; } = null!;

    public string MedicineName { get; set; } = null!;

    public int? StockQuantity { get; set; }

    public decimal? UnitPrice { get; set; }

    public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; set; } = new List<PrescriptionDetail>();
}
