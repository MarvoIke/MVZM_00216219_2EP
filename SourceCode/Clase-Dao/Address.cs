namespace parcialDos
{
    public class Address
    {
        public int idAddress { set; get; }
        public int idUser { set; get; }
        public string address { set; get; }
        
        public Address(){}
        
        public Address(int idAddress , int idUser , string address)
        {
            this.idAddress = idAddress;
            this.idUser = idUser;
            this.address = address;
        }
    }
}