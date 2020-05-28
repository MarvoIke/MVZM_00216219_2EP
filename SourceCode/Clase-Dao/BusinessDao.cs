using System;
using System.Collections.Generic;
using System.Data;

namespace parcialDos
{
    public class BusinessDao
    {
        public static List<Business> GetLista()
        {
            string sql = "SELECT * FROM business";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Business> listAux = new List<Business>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Business aux = new Business();
                aux.idBusiness = Convert.ToInt32(fila[0]);
                aux.name = fila[1].ToString();
                aux.description = fila[2].ToString();
                listAux.Add(aux);
            }
            return listAux;
        }

        public static void AddBusi(Business unNego)
        {
            string sql = string.Format("INSERT INTO business(name, description)" +
                                       "VALUES('{0}' , '{1}')",
                unNego.name , unNego.description);
            Connection.ExecuteNonQuery(sql);
        }
        
        public static void DelBusi(string eliminado)
        {
            string sql = string.Format("DELETE FROM business WHERE name = '{0}'",
                eliminado);
            Connection.ExecuteNonQuery(sql);
        }
    }
}