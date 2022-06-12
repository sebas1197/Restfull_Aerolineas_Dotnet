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
    public class ClienteController : ApiController
    {

        private VuelosServicio servicio = new VuelosServicio();
        private DB bd = new DB();

        // GET api/values
        public List<ClienteModel> Get(string nombre, string apellido, string cedula)
        {
            return this.bd.registroCliente(nombre, apellido, cedula);

        }

        // GET api/values/5
        public int Get(int aux)
        {
            return this.bd.ultimoCliente();
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
