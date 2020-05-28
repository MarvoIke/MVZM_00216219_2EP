using System;
using System.Collections.Generic;
using System.Data;

namespace parcialDos
{
    public class ProductDao
    {
        public static List<Product> GetLista()
        {
            string sql = "SELECT * FROM product";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Product> listAux = new List<Product>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Product aux = new Product();
                aux.idProduct = Convert.ToInt32(fila[0]);
                aux.idBusiness = Convert.ToInt32(fila[1]);
                aux.name = fila[2].ToString();
                listAux.Add(aux);
            }
            return listAux;
        }
        
        public static List<Product> GetLista(Business unBusi)
        {
            string sql = $"SELECT * FROM product WHERE idbusiness = {unBusi.idBusiness}";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Product> listAux = new List<Product>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Product aux = new Product();
                aux.idProduct = Convert.ToInt32(fila[0]);
                aux.idBusiness = Convert.ToInt32(fila[1]);
                aux.name = fila[2].ToString();
                listAux.Add(aux);
            }
            return listAux;
        }

        public static void AddProd(Product unProd)
        {
            string sql = string.Format("INSERT INTO product(idbusiness, name)" +
                                       "VALUES({0} , '{1}')",
                unProd.idBusiness , unProd.name);
            Connection.ExecuteNonQuery(sql);
        }
        
        public static void DelProd(string eliminado)
        {
            string sql = string.Format("DELETE FROM product WHERE name = '{0}'",
                eliminado);
            Connection.ExecuteNonQuery(sql);
        }
    }
}