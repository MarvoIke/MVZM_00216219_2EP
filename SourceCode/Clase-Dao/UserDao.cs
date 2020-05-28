using System;
using System.Collections.Generic;
using System.Data;

namespace parcialDos
{
    public class UserDao
    {
        public static List<User> GetLista()
        {
            string sql = "SELECT * FROM appuser";
            DataTable tabla = Connection.ExecuteQuery(sql);
            List<User> listAux = new List<User>();
            
            foreach (DataRow fila in tabla.Rows)
            {
                User aux = new User();
                aux.idUser = Convert.ToInt32(fila[0]);
                aux.fullName = fila[1].ToString();
                aux.userName = fila[2].ToString();
                aux.password = fila[3].ToString();
                aux.userType = Convert.ToBoolean(fila[4]);
                listAux.Add(aux);
            }
            return listAux;
        }

        public static string getCredential(string user)
        {
            string contra = "";
            string consulta = $"SELECT password FROM appuser WHERE username = '{user}';";
            DataTable dt = Connection.ExecuteQuery(consulta);
            foreach (DataRow dr in dt.Rows)
            {
                contra = dr[0].ToString();
            }

            return contra;
        }
        
        public static bool isAdmin(string user)
        {
            bool si = false;
            string consulta = $"SELECT usertype FROM appuser WHERE username = '{user}';";
            DataTable dt = Connection.ExecuteQuery(consulta);
            foreach (DataRow dr in dt.Rows)
            {
                si = Convert.ToBoolean(dr[0]);
            }

            return si;
        }

        public static void AddUser(User unUser)
        {
            string sql = string.Format("INSERT INTO appuser(fullname, username, password, userType)" +
                                       "VALUES('{0}' , '{1}' , '{2}' , {3})",
                unUser.fullName , unUser.userName , unUser.password , unUser.userType);
            Connection.ExecuteNonQuery(sql);
        }
        
        public static void DeleteUser(string sefue)
        {
            string sql = string.Format("DELETE FROM appuser WHERE username = '{0}'",
                sefue);
            Connection.ExecuteNonQuery(sql);
        }
        
        public static void UpdatePass(string actualizar , string user)
        {
            string sql = $"UPDATE appuser SET password = '{actualizar}' WHERE username = '{user}'";
                Connection.ExecuteNonQuery(sql);
        }
    }
}