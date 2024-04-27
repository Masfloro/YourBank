using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
namespace YourBank.Models.Entity
{

    [Table("t_cuentas")]
    public class Cuentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [NotNull]
        public String Nombre { get; set; }
        [NotNull]
        public String TipoCuenta { get; set; }
        [NotNull]
        public Double SaldoInicial { get; set; }
        [NotNull]
        public String Correo { get; set; }

    }



}
