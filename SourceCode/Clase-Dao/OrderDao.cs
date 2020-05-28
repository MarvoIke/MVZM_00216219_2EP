using System;
using System.Collections.Generic;
using System.Data;

namespace parcialDos
{
    public class OrderDao
    {
        public static List<Order> GetLista()
        {
            string sql = "SELECT * FROM apporder";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Order> listAux = new List<Order>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Order aux = new Order();
                aux.idOrder = Convert.ToInt32(fila[0]);
                aux.createdate = Convert.ToDateTime(fila[1]);
                aux.idProduct = Convert.ToInt32(fila[2]);
                aux.idAddress = Convert.ToInt32(fila[3]);
                listAux.Add(aux);
            }
            return listAux;
        }
        
        public static List<Order> GetLista(int idAddress)
        {
            string sql = $"SELECT * FROM apporder WHERE idaddress = {idAddress}";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Order> listAux = new List<Order>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Order aux = new Order();
                aux.idOrder = Convert.ToInt32(fila[0]);
                aux.createdate = Convert.ToDateTime(fila[1]);
                aux.idProduct = Convert.ToInt32(fila[2]);
                aux.idAddress = Convert.ToInt32(fila[3]);
                listAux.Add(aux);
            }
            return listAux;
        }
        
        public static void AddOrden(Order unaOrden)
        {
            string sql = string.Format("INSERT INTO apporder(createdate , idproduct , idaddress)" +
                                       "VALUES(DATE '{0}' , {1} , {2})",
                unaOrden.createdate , unaOrden.idProduct , unaOrden.idAddress);
            Connection.ExecuteNonQuery(sql);
        }
    }
}