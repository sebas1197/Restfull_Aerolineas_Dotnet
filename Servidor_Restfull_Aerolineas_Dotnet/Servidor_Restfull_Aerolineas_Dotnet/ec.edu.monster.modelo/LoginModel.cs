using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo
{
    public class LoginModel
    {
        public LoginModel(string usuario, string clave)
        {
            this.usuario = usuario;
            this.clave = clave;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(20)]
        public string usuario { get; set; }

        [StringLength(20)]
        public string clave { get; set; }
    }
}