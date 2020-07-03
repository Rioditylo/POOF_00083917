﻿using System.Collections.Generic;
using System.Data;
using FinalParcial.ClaseBD;

namespace FinalParcial.Strategy
{
    public class SVigilant : IStrategy
    {
        
        public void add(List<string> list)
        {
            EmployeeController.Add(list[0],list[1],list[2],list[3],list[4],2);

        }

        public void delete(int id)
        {
            EmployeeController.delete(id);
        }

        public void update(string idDep, string pass, string id)
        {
            EmployeeController.update(idDep,  pass,  id);
        }

        public DataTable show()
        {
            return EmployeeController.showVigilate();
        }
    }
}