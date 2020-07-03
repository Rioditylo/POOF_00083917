using System;
using System.Collections.Generic;
using System.Data;
using FinalParcial.ClaseBD;
using FinalParcial.Model;

namespace FinalParcial.Clasescomunes
{
    public class AddUsuario
    {
        public static List<User> GetLista()
        {
            string sql = "select * from USUARIO";

            DataTable dt = Connection.Query(sql);

            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.idUser = Convert.ToInt32(fila[0].ToString());
                u.idDepartament = Convert.ToInt32(fila[1].ToString());
                u.password = fila[2].ToString();
                u.name = fila[3].ToString();
                u.lastname = fila[4].ToString();
                u.dui =  fila[5].ToString();
                u.date = fila[6].ToString();
               

                lista.Add(u);
            }
            return lista;
        }
        
        public static void Changepassword(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update USUARIO set contrasenia='{2}' where nombre='{3}';",
                nuevaContra, usuario);
            
            Connection.NoQuery(sql);
        }
        
        
        
        
        
    }
}