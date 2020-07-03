using System.Collections.Generic;
using System.Data;

namespace FinalParcial.Strategy
{
    public interface IStrategy
    {
        void add(List<string> list);
        void delete(int id);
        void update(string idDep, string pass, string id);
        
        DataTable show();
    }
}