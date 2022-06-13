using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Servidor_Restfull_Aerolineas_Dotnet.ec.edu.monster.modelo
{
    public class DB
    {
        public List<VuelosModel> listarVuelos()
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "SELECT * FROM vuelos";

            List<VuelosModel> vuelos = new List<VuelosModel>();
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                
                while (rdr.Read())
                {
                    VuelosModel model = new VuelosModel(int.Parse(rdr["id"].ToString()),rdr["ciudad_origen"].ToString(), rdr["ciudad_destino"].ToString(), rdr["valor"].ToString(), rdr["hora_salida"].ToString());
                    vuelos.Add(model);
                }
            }
            return vuelos;
        }


        public Boolean comprarVuelo(int vueloID, int clienteID)
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "INSERT INTO boletos (VUELO_ID, CLIENTE_ID) VALUES ('"+ vueloID + "', '" + clienteID + "');";

            
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                return true;

            }
            else
            {
                return false;
            }
            

        }

        public List<VuelosModel> listarVuelosPorPrecio()
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "SELECT * FROM vuelos WHERE valor = (SELECT max(valor) from vuelos);";

            List<VuelosModel> vuelos = new List<VuelosModel>();
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    VuelosModel model = new VuelosModel(int.Parse(rdr["id"].ToString()), rdr["ciudad_origen"].ToString(), rdr["ciudad_destino"].ToString(), rdr["valor"].ToString(), rdr["hora_salida"].ToString());
                    vuelos.Add(model);
                }
            }
            else
            {
                VuelosModel model = new VuelosModel(0,"Vuelo no disponible", "Vuelo no disponible", "Vuelo no disponible", "Vuelo no disponible");
                vuelos.Add(model);
            }
            return vuelos;
        }

        public List<ClienteModel> registroCliente(string nombre, string apellido, string cedula)
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "INSERT INTO cliente (nombre, apellido, cedula) VALUES ('" + nombre + "', '" + apellido + "', '" + cedula + "');";
           
            List<ClienteModel> clientes = new List<ClienteModel>();
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    ClienteModel model = new ClienteModel(rdr["nombre"].ToString(), rdr["apellido"].ToString(), rdr["cedula"].ToString());                    
                    clientes.Add(model);
                }
            }
            
            return clientes;
        }

        public Boolean login(string usuario, string clave)
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "SELECT * FROM login WHERE usuario='" + usuario + "' AND clave='" + clave + "'";

            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int ultimoCliente()
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "SELECT max(id) as ID FROM cliente;";

            int id = 1;
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    id = int.Parse(rdr["id"].ToString());
                }
            }

            return id;
        }

        public List<BoletosModel> boleto()
        {
            String cad = "Data Source=DESKTOP-V7GCBLV; Initial Catalog=viajecitossa; Integrated Security=True";
            String query = "SELECT * FROM BOLETOS JOIN Cliente on CLIENTE_ID = Cliente.ID JOIN VUELOS on VUELO_ID = VUELOS.ID WHERE BOLETOS.ID = (SELECT MAX(ID) FROM BOLETOS);";

            List<BoletosModel> boletos = new List<BoletosModel>();
            SqlConnection con = new SqlConnection(cad);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.HasRows)
            {

                while (rdr.Read())
                {
                    BoletosModel model = new BoletosModel(rdr["nombre"].ToString(), rdr["apellido"].ToString(),
                        rdr["cedula"].ToString(), int.Parse(rdr["vuelo_id"].ToString()),
                        rdr["ciudad_origen"].ToString(), rdr["ciudad_destino"].ToString(),
                        float.Parse(rdr["valor"].ToString()), rdr["hora_salida"].ToString());
                    boletos.Add(model);
                }
            }

            return boletos;
        }

    }
}