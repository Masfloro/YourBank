using Microsoft.EntityFrameworkCore;
using YourBank.Models.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace YourBank.Data{
public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // Define aquí tus DbSet para las entidades de tu base de datos

    public DbSet<Cuentas> DataCuentas { get; set; }





}


}