namespace parcialDos
{
    public class Product
    {
        public int idProduct { set; get; }
        public int idBusiness { set; get; }
        public string name { set; get; }
        
        public Product() {}

        public Product(int idBusiness, string name)
        {
            this.idBusiness = idBusiness;
            this.name = name;
        }

        public Product(int idProduct , int idBusiness, string name)
        {
            this.idProduct = idProduct;
            this.idBusiness = idBusiness;
            this.name = name;
        }
    }
}