namespace parcialDos
{
    public class User
    {
        public int idUser { set; get; }
        public string fullName { set; get; }
        public string userName { set; get; }
        public string password { set; get; }
        public bool userType { set; get; }
        
        public User(){}

        public User(string fullName, string userName, string password, bool userType)
        {
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
        }

        public User(int idUser , string fullName, string userName, string password, bool userType)
        {
            this.idUser = idUser;
            this.fullName = fullName;
            this.userName = userName;
            this.password = password;
            this.userType = userType;
        }
    }
}