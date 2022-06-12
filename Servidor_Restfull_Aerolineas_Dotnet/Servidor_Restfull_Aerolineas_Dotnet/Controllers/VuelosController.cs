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
    public class VuelosController : ApiController
    {

        private VuelosServicio servicio = new VuelosServicio();
        private DB bd = new DB();

        // GET api/values
        public List<VuelosModel> Get()
        {
            return this.bd.listarVuelos();

        }

        // GET api/values/5
        public List<VuelosModel> Get(int aux)
        {
            return this.bd.listarVuelosPorPrecio();
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
