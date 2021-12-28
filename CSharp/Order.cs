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
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy {get; set; }
    public datetime modifiedDateUTC { get; set; }
}
