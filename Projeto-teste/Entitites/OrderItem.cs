using System.Text;
namespace Projeto_teste.Entitites
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {

        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            double sum = Price * Quantity;
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Product.Name + ", ");
            sb.Append("$" + Price.ToString("F2") + " ");
            sb.Append("Quantity: " + Quantity);
            sb.Append(" Total: ");
            sb.Append(SubTotal().ToString("F2"));

            return sb.ToString();
        }

    }

}
