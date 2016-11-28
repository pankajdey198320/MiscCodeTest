
public class Rootobject
{
    public Record[] Records { get; set; }
}

public class Record
{
    public string PatientId { get; set; }
    public Dosage[] Dosage { get; set; }
}

public class Dosage
{
    public string MedicineDescription { get; set; }
    public string RouteOfAdminCode { get; set; }
    public string DosageFormCode { get; set; }
    public string SIGText { get; set; }
    public string StartDate { get; set; }
    public string DailyQuantity { get; set; }
    public string DoseFrequency { get; set; }
    public string ExpirationDate { get; set; }
}
