using System.ComponentModel.DataAnnotations;

namespace HospitalApi.Models;

public class Diagnose
{
    [Key] public int Id { get; set; }

    public string? Body { get; set; }

    public DateOnly? Date { get; set; }
}