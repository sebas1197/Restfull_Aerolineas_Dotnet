using Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo;
using Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Servidor_Restfull_Aerolineas_Dotnet.Controllers
{
    public class BoletosController : ApiController
    {

        private VuelosServicio servicio = new VuelosServicio();
        private DB bd = new DB();

       


        public List<BoletosModel> Get(int vueloID, int clienteID)
        {
            return this.bd.comprarVuelo(vueloID, clienteID);
        }


    }
}
