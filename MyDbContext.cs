using HospitalApi.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalApi;

public class MyDbContext : DbContext
{

    // Какие таблицы есть в базе данных
    public DbSet<Diagnose> Diagnose { get; set; } = null!;
    public DbSet<Doctor> Doctor { get; set; } = null!;
    public DbSet<DocDiagnose> DocDiagnoses { get; set; } = null!;

    // Метод, реализующий подключение к базе данных
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Строка подключения
        optionsBuilder.UseNpgsql("Host=172.17.0.1;Database=ReactHospital;Username=postgres;Password=123");
    }
}
