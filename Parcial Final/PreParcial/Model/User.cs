using System;

namespace FinalParcial.Model
{
    public class User
    {
        public int idUser { get; set; }
        public int idDepartament { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string dui { get; set; }
        public string date { get; set; }

        public User()
        {
            idUser = 0;
            idDepartament = 0;
            password = "";
            name = "";
            lastname = "";
            dui ="";
            date = "";
        }
    }
}