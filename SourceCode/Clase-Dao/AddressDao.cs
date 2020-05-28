using System;
using System.Collections.Generic;
using System.Data;

namespace parcialDos
{
    public class AddressDao
    {
        public static List<Address> GetLista()
        {
            string sql = "SELECT * FROM address";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Address> listAux = new List<Address>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Address aux = new Address();
                aux.idAddress = Convert.ToInt32(fila[0]);
                aux.idUser = Convert.ToInt32(fila[1]);
                aux.address = fila[2].ToString();
                listAux.Add(aux);
            }
            return listAux;
        }
        
        public static List<Address> GetLista(int idUser)
        {
            string sql = $"SELECT * FROM address WHERE iduser = {idUser}";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<Address> listAux = new List<Address>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                Address aux = new Address();
                aux.idAddress = Convert.ToInt32(fila[0]);
                aux.idUser = Convert.ToInt32(fila[1]);
                aux.address = fila[2].ToString();
                listAux.Add(aux);
            }
            return listAux;
        }
        
        public static void AddAddress(Address unaDire)
        {
            string sql = string.Format("INSERT INTO address(idUser, address)" +
                                       "VALUES({0} , '{1}')",
                unaDire.idUser , unaDire.address);
            Connection.ExecuteNonQuery(sql);
        }
        
        public static void DelAddress(string eliminado)
        {
            string sql = string.Format("DELETE FROM address WHERE address = '{0}'",
                eliminado);
            Connection.ExecuteNonQuery(sql);
        }
    }
}