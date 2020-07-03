using System;
using System.Data;
using FinalParcial.Exception;
using FinalParcial.Model;

namespace FinalParcial.ClaseBD
{
    public static class DepartamentController
    {
        public static void Add(string name,string Location)
        {
            string noSql = $"INSERT INTO public.departamento(nombre, ubicacion) VALUES ('{name}', '{Location}');";
            Connection.NoQuery(noSql);
        }
        public static Departament Select(string id)
        {
            string sql = $"SELECT iddepartamento, nombre, ubicacion FROM public.departamento where iddepartamento={id};";
            var department = Connection.Query(sql);

            if (department.Rows.Count == 0)
            {
                throw new DepartmentException("No existe el usuario");
            }
            Departament u=new Departament();
            u.name=department.Rows[0][1].ToString();
            u.idDepartament=Convert.ToInt32(department.Rows[0][0].ToString());
            u.Location=u.name=department.Rows[0][2].ToString();
            return u;
        }

        
        
    }
}