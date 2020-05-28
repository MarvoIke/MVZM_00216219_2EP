namespace parcialDos
{
    public class Business
    {
        public int idBusiness { set; get; }
        public string name { set; get; }
        public string description { set; get; }
        
        public Business() {}

        public Business(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public Business(int idBusiness , string name, string description)
        {
            this.idBusiness = idBusiness;
            this.name = name;
            this.description = description;
        }
    }
}