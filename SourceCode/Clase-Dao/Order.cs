using System;

namespace parcialDos
{
    public class Order
    {
        public int idOrder { set; get; }
        public DateTime createdate { set; get; }
        public int idProduct { set; get; }
        public int idAddress { set; get; }
        
        public Order () {}

        public Order(int idOrder , int idProduct , int idAddress)
        {
            this.idOrder = idOrder;
            createdate = DateTime.Now;
            this.idProduct = idProduct;
            this.idAddress = idAddress;
        }
    }
}