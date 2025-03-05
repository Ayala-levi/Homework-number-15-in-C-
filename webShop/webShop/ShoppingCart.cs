namespace webShop
{
    public class ShoppingCart
    {
        private List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        //public void AddItem(Product product)
        //{
        //    items.Add(product);
        //}

        //public void RemoveItem(Product product)
        //{
        //    items.Remove(product);
        //}

        //public double CalculateTotal()
        //{
        //    double total = 0;
        //    foreach (var item in items)
        //    {
        //        total += item.Price;
        //    }
        //    return total;
        //}

        //public void PrintCartItems()
        //{
        //    foreach (var item in items)
        //    {
        //        Console.WriteLine(item.ToString());
        //    }
        //}
    }
}
