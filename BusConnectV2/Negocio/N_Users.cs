using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class N_Users
    {
        UsuariosData usuarios = new UsuariosData();

        public int N_registrar_consulta(string consulta, string id)
        {
            return usuarios.Consultas_register(consulta, id);
        }

        public DataTable N_user(Usuarios obje)
        {
            return usuarios.Usuarios_data(obje);
        }
        public DataTable N_getusers()
        {
            return usuarios.getUsers();
        }
        public int N_register(Usuarios obje, byte[] xfoto)
        {
            return usuarios.Usuarios_register(obje, xfoto);
        }

        public int N_editUser(Usuarios obje)
        {
            return usuarios.PASSUpdateAdmin(obje);
        }

        public int N_EMPregister(Usuarios obje)
        {
            return usuarios.Empresa_register(obje);
        }

        public int N_AvisoRegister(Avisos obje)
        {
            return usuarios.Avisos_Register(obje);
        }
        public int N_EMPDelete(Usuarios obje)
        {
            return usuarios.EliminarEmp(obje);
        }
        public DataTable N_GetEmpresas()
        {
            return usuarios.Empresas_data();
        }

        public DataTable N_GetConsultas()
        {
            return usuarios.Consultas_data();
        }
        public DataTable N_ConsultasUser(string id)
        {
            return usuarios.getConsultasUser(id);
        }
        public DataTable N_GetLineas()
        {
            return usuarios.getLineas();
        }

        public DataTable N_GetLineasemp(int codEmp)
        {
            return usuarios.getLineasemp(codEmp);
        }

        public DataTable N_GetSuscripciones(string id)
        {
            return usuarios.getSuscripciones(id);
        }

        public DataTable n_getavisos(int linea)
        {
            return usuarios.getAvisos(linea);
        }
        public DataTable n_getavisosVencidos(int linea)
        {
            return usuarios.getAvisosVencidos(linea);
        }

        public int N_SuscribirseLinea(string id, int linea)
        {
            return usuarios.SuscribirseLinea(id, linea);
        }

        public int N_ResponderConsulta(int consulta, string respuesta)
        {
            return usuarios.ResponderConsulta(consulta, respuesta);
        }

        public int N_UpdatePass(Usuarios obje, string id, string newPass)
        {
            return usuarios.PASSUpdate(obje, id, newPass);
        }

        public int N_addImagen(byte[] xfoto, string id)
        {
            return usuarios.AddImagen(xfoto, id);
        }

        public DataTable N_getImagen(string id)
        {
            return usuarios.getImagen(id);
        }

        public int N_addLinea(Linea obje)
        {
            return usuarios.addLinea(obje);
        }

        public int N_addRamal(Ramales obje)
        {
            return usuarios.addRamal(obje);
        }

        public int N_addColectivo(Colectivos obje)
        {
            return usuarios.addColectivo(obje);
        }

        public DataTable N_getCodEmpresa(Usuarios obje)
        {
            return usuarios.GetEmpresa(obje);
        }

        public int N_Ubicaciones_register(RamalesUbi obje)
        {
            return usuarios.Ubicaciones_register(obje);
        }

        public DataTable N_GetRamal(int codLinea)
        {
            return usuarios.getRamal(codLinea);
        }

        public DataTable N_GetUbi(int codRamal)
        {
            return usuarios.getUbi(codRamal);
        }
    }
}
