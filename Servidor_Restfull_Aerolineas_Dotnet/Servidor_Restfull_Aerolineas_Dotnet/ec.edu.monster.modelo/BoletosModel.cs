using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo
{
    public class BoletosModel
    {

        public BoletosModel(int vuelosID, int clienteID)
        {
            this.vuelosID = vuelosID;
            this.clienteID = clienteID;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int vuelosID { get; set; }
        public int clienteID { get; set; }






    }
}