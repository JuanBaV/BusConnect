using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using BLL;

namespace DAL
{
    public class UsuariosData
    {
        SqlConnection cn = new SqlConnection("Data Source=localhost;Initial Catalog=BusConnect;Integrated Security=True");
        //inicio de sesion
        public DataTable Usuarios_data(Usuarios obje)
        {
            SqlCommand cmd = new SqlCommand("logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.ID);
            cmd.Parameters.AddWithValue("@Password", obje.Contraseña);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //registro de usuarios
        public int Usuarios_register(Usuarios obje, byte[] xfoto)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("registro", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.ID);
            cmd.Parameters.AddWithValue("@Imagen", xfoto);
            cmd.Parameters.AddWithValue("@Password", obje.Contraseña);
            cmd.Parameters.AddWithValue("@Role", obje.Role);
            return check(cmd);
        }

        //registro de empresas
        public int Empresa_register(Usuarios obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("registroEMP", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NombreEmp", obje.ID);
            cmd.Parameters.AddWithValue("@PasswordEmp", obje.Contraseña);
            return check(cmd);
        }

        //envio de consultas
        public int Consultas_register(string consulta, string id)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("realizarConsulta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@consulta", consulta);
            cmd.Parameters.AddWithValue("@usuario", id);
            cmd.Parameters.AddWithValue("@respuesta", "vacio");
            return check(cmd);
        }

        public DataTable getAvisos(int linea)
        {
            SqlCommand cmd = new SqlCommand("select * from Avisos where Linea=@linea and FechaFin>@hoy ", cn);
            cmd.Parameters.AddWithValue("@linea", linea);
            cmd.Parameters.AddWithValue("@hoy", DateTime.Now);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable getAvisosVencidos(int linea)
        {
            SqlCommand cmd = new SqlCommand("select * from Avisos where Linea=@linea and FechaFin<@hoy ", cn);
            cmd.Parameters.AddWithValue("@linea", linea);
            cmd.Parameters.AddWithValue("@hoy", DateTime.Now);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable getSuscripciones(string id)
        {
            SqlCommand cmd = new SqlCommand("select * from suscripciones where ID_Usuario=@id ", cn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }




        //registro de avisos
        public int Avisos_Register(Avisos obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("registroAnuncios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@titulo", obje.titulo);
            cmd.Parameters.AddWithValue("@descripcion", obje.descripcion);
            cmd.Parameters.AddWithValue("@fechai", obje.inicio);
            cmd.Parameters.AddWithValue("@fechafin", obje.fin);
            cmd.Parameters.AddWithValue("@linea", obje.linea);
            return check(cmd);
        }

        //eliminacion de empresas
        public int EliminarEmp(Usuarios obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("ElimEmp", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.ID);
            return check(cmd);
        }

        //verificacion de ejecucion de comando
        public int check(SqlCommand cmd)
        {
            try
            {
                int i = cmd.ExecuteNonQuery();
                cn.Close();
                return i;
            }
            catch (Exception)
            {
                cn.Close();
                return -1;
            }
        }

        //obtencion de empresas
        public DataTable Empresas_data()
        {
            SqlCommand cmd = new SqlCommand("Select * from Empresas", cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        //obtener consultas sin responder
        public DataTable Consultas_data()
        {

            SqlCommand cmd = new SqlCommand("Select * from Consultas where Respuesta=@respuesta", cn);
            cmd.Parameters.AddWithValue("@respuesta", "vacio");
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //obtener consultas de un usuario en especifico
        public DataTable getConsultasUser(string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Consultas where ID_Usuario=@id", cn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //obtencion de lineas
        public DataTable getLineas()
        {
            SqlCommand cmd = new SqlCommand("Select * from Lineas", cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable getLineasemp(int codEmp)
        {
            SqlCommand cmd = new SqlCommand("Select * from Lineas where codEmpresa=@codEmp ", cn);
            cmd.Parameters.AddWithValue("@codEmp", codEmp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }


        public DataTable getUsers()
        {
            SqlCommand cmd = new SqlCommand("Select * from Usuarios ", cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //suscribirse a una linea
        public int SuscribirseLinea(string id, int linea)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("suscribirse", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@linea", linea);
            return check(cmd);
        }

        //responder consulta
        public int ResponderConsulta(int consulta, string respuesta)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("responderConsulta", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nroconsulta", consulta);
            cmd.Parameters.AddWithValue("@respuesta", respuesta);
            return check(cmd);
        }

        //actualizacion de contraseñas
        public int PASSUpdate(Usuarios obje, string id, string newPass)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("ActPassword", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Password", obje.Contraseña);
            cmd.Parameters.AddWithValue("@NewPass", newPass);
            return check(cmd);
        }

        public int PASSUpdateAdmin(Usuarios obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("editUsers", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", obje.ID);
            cmd.Parameters.AddWithValue("@pass", obje.Contraseña);
            return check(cmd);
        }


        //agregar imagen al usuario
        public int AddImagen(byte[] xfoto, string id)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("addImage", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@Imagen", xfoto);

            return check(cmd);
        }

        //obtener la imagen del usuario
        public DataTable getImagen(string id)
        {
            SqlCommand cmd = new SqlCommand("getImage", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID", id);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //registrar una linea
        public int addLinea(Linea obje)
        {
            cn.Open();
            SqlTransaction myTrans;
            myTrans = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("RegistroLinea", cn);
                cmd.Transaction = myTrans;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEmpresa", obje.codEmpresa);
                cmd.Parameters.AddWithValue("@nro", obje.nro);
                myTrans.Commit();
                return check(cmd);
            }
            catch (Exception ex)
            {
                myTrans.Rollback();

                
                throw;
            }
            //SqlCommand cmd = new SqlCommand("RegistroLinea", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@codEmpresa", obje.codEmpresa);
            //cmd.Parameters.AddWithValue("@nro", obje.nro);

            //return check(cmd);
        }

        //registrar un ramal
        public int addRamal(Ramales obje)
        {
            cn.Open();
            SqlTransaction myTrans;
            myTrans = cn.BeginTransaction();
            try
            {
                SqlCommand cmd = new SqlCommand("Registroramal", cn);
                cmd.Transaction = myTrans;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codRamal", obje.codRamal);
                cmd.Parameters.AddWithValue("@codLinea", obje.codLinea);
                cmd.Parameters.AddWithValue("@Descripcion", obje.descripcion);
                myTrans.Commit();
                return check(cmd);
            }
            catch (Exception ex)
            {
                myTrans.Rollback();


                throw;
            }
            //SqlCommand cmd = new SqlCommand("Registroramal", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@codRamal", obje.codRamal);
            //cmd.Parameters.AddWithValue("@codLinea", obje.codLinea);
            //cmd.Parameters.AddWithValue("@Descripcion", obje.descripcion);
            //return check(cmd);
        }

        //registrar un colectivo
        public int addColectivo(Colectivos obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("RegistroColectivo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codRamal", obje.Ramal);
            cmd.Parameters.AddWithValue("@Modelo", obje.Modelo);
            cmd.Parameters.AddWithValue("@color", obje.color);
            return check(cmd);
        }

        //obtener el codigo de empresa
        public DataTable GetEmpresa(Usuarios obje)
        {
            SqlCommand cmd = new SqlCommand("getEmpresa", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obje.ID);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //RegistroUbicaciones
        public int Ubicaciones_register(RamalesUbi obje)
        {
            cn.Open();
            SqlCommand cmd = new SqlCommand("GuardarUbicaciones", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CodRamal", obje.CodRamal);
            cmd.Parameters.AddWithValue("@Descripcion", obje.Descripcion);
            cmd.Parameters.AddWithValue("@Latitud", obje.Latitud);
            cmd.Parameters.AddWithValue("@Longitud", obje.Longitud);
            return check(cmd);
        }

        //Obtener Ramal segun linea
        public DataTable getRamal(int codLinea)
        {
            SqlCommand cmd = new SqlCommand("Select * from Ramales where codLinea=@codLinea ", cn);
            cmd.Parameters.AddWithValue("@codLinea", codLinea);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }

        //Obtener Ubicaciones segun ramal
        public DataTable getUbi(int codRamal)
        {
            SqlCommand cmd = new SqlCommand("Select * from RamalesUbi where codRamal=@codRamal ", cn);
            cmd.Parameters.AddWithValue("@codRamal", codRamal);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
