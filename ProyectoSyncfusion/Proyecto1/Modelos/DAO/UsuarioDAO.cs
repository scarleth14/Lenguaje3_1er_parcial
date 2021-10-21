﻿using Proyecto1.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proyecto1.Modelos.DAO
{
    class UsuarioDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool ValidarUsuario(Usuario user)
        {
            bool valido = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT 1 FROM USUARIO WHERE EMAIL = @Email AND CLAVE = @Clave;");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("Email", SqlDbType.NVarChar, 50).Value = user.Email;
                comando.Parameters.Add("Clave", SqlDbType.NVarChar, 100).Value = user.Clave;
                valido = Convert.ToBoolean(comando.ExecuteScalar());
            }
            catch (Exception)
            {

                
            }
            return valido;
        }

    }
}
