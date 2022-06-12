using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo
{
    public class VuelosModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VuelosModel()
        {
            boletos = new HashSet<BoletosModel>();
        }

        public VuelosModel(int id, string ciudadOrigen, string ciudadDestino, string valor, string horaSalida)
        {
            this.ID = id;
            this.ciudadOrigen = ciudadOrigen;
            this.ciudadDestino = ciudadDestino;
            this.valor = valor;
            this.horaSalida = horaSalida;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string ciudadOrigen { get; set; }

        [StringLength(50)]
        public string ciudadDestino { get; set; }

        [StringLength(10)]
        public string valor { get; set; }

        [StringLength(20)]
        public string horaSalida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BoletosModel> boletos { get; set; }

    }
}