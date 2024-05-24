using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models;

public class DocDiagnose
{
    
    // primary key Id
    [Key] public int Id { get; set; }

    // связь с врачом
    public int? DocId { get; set; }
    
    // связь с диагнозом
    public int? DiagId { get; set; }
}