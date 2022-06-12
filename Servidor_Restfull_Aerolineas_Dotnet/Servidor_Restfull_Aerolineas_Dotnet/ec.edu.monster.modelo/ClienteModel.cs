using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo
{
    public class ClienteModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClienteModel(string nombre, string apellido, string cedula)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(20)]
        public string nombre { get; set; }

        [StringLength(20)]
        public string apellido { get; set; }

        [StringLength(20)]
        public string cedula { get; set; }
    }

}