using System;
using System.Collections.Generic;
using System.Data;
using FinalParcial.Exception;
using FinalParcial.Model;

namespace FinalParcial.ClaseBD
{
    public static class EmployeeController
    {
        public static User Exist(string nameU, string password)
        {
            string sql = $"SELECT idusuario, iddedepartamento, contrasenia, nombre, apellido, dui, fechanacimiento " +
                         $"FROM public.usuario " +
                         $"where nombre='{nameU}' and contrasenia='{password}';";
            var user = Connection.Query(sql);

            if (user.Rows.Count == 0)
            {
                throw new UserException("No existe el usuario");
            }
            User u=new User();
            u.idUser= Convert.ToInt32(user.Rows[0][0].ToString());
            u.idDepartament= Convert.ToInt32(user.Rows[0][1].ToString());
            u.name = user.Rows[0][3].ToString();
            u.lastname = user.Rows[0][4].ToString();
            u.dui = user.Rows[0][5].ToString();
            return u;
        }

        public static List<User> Users(int id)
        {
            string sql = $"SELECT nombre, apellido, dui , iddedepartamento FROM \"usuario\" where iddedepartamento={id};";
            List<User> list = new List<User>();
            DataTable dt= Connection.Query(sql);
            foreach (DataRow fila in dt.Rows)
            {
                User u= new User();
                u.name = fila[0].ToString();
                u.lastname=(fila[1].ToString());
                u.dui = fila[2].ToString();
                list.Add(u);
            }
            return list;
        }
        public static void Add(string nameU,string lastname,string password,string dui, string date,int dep)
        {
            string noSql = $"INSERT INTO public.usuario(iddedepartamento, contrasenia, nombre, apellido, dui, fechanacimiento) " +
                           $"VALUES ( {dep}, '{password}', '{nameU}', '{lastname}', '{dui}', '{date}');";
            Connection.NoQuery(noSql);
        }
        public static void update(string idDep, string password,string id)
        {
            string noSql = $"UPDATE public.usuario SET iddedepartamento={idDep}, contrasenia='{password}' WHERE idusuario= {id};";
            Connection.NoQuery(noSql);
        }

        public static void delete(int id)
        {
             Connection.NoQuery($"DELETE FROM public.usuario WHERE idusuario={id};");

        }
        public static DataTable showVigilate()
        {
            return Connection.Query("Select * from usuario where iddedepartamento=2");

        }
        public static DataTable showAdmin()
        {
            return Connection.Query("Select * from usuario where iddedepartamento=1");

        }
        public static DataTable showEmloyee()
        {
            return Connection.Query("Select * from usuario where iddedepartamento=3");

        }
    }
}