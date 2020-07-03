using System.Data;

namespace FinalParcial.ClaseBD
{
    public static class RegisterController
    {
        public static void add(int id,string fecha, int temp, bool status)
        {
            Connection.NoQuery($"INSERT INTO public.registro(idusuario, entrada, fechahora, temperatura) " +
                               $"VALUES ( {id}, {status}, '{fecha}', {temp});");
        }
        public static bool Status(int id)
        {
            var status = Connection.Query($"select * from registro where idusuario={id} and entrada=true");
            if (status.Rows.Count==0)
            {
                return false;
            }
            return true;
        }
        public static DataTable count(int id)
        {
           return Connection.Query($"SELECT count(*) FROM registro where idusuario={id};");
        }
    }
}