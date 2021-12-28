public class Order
{
    public long ID { get; set; }
    public string customerName { get; set; }
    public string itemSKU { get; set; }
    public int itemQty { get; set; }
    public decimal itemPrice { get; set; }
    public string currencyCode { get; set; }
    // order status (e.g. PENDING, ACTIVE, CANCELLED, COMPLETED)
    public string status { get; set; }
}
