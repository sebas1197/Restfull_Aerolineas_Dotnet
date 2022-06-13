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

        public BoletosModel(string nombre, string apellido, string cedula, int vuelo_id, string ciudad_origen, string ciudad_destino, float valor, string hora_salida)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.vuelo_id = vuelo_id;
            this.ciudad_origen = ciudad_origen;
            this.ciudad_destino = ciudad_destino;
            this.valor = valor;
            this.hora_salida = hora_salida;
        }
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int vuelosID { get; set; }
        public int clienteID { get; set; }

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string cedula { get; set; }
        public int vuelo_id { get; set; }
        public string ciudad_origen { get; set; }
        public string ciudad_destino { get; set; }
        public float valor { get; set; }
        public string hora_salida { get; set; }




    }
}