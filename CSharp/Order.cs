public class Order
{
    public long ID { get; set; }
    public Customer customer { get; set; }
    public list<OrderDetail> orderDetails { get; set; }
    public decimal totalAmount { get; set; }
    public string currencyCode { get; set; }
    // order status (e.g. PENDING, ACTIVE, CANCELLED, COMPLETED)
    public string status { get; set; }
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy {get; set; }
    public datetime modifiedDateUTC { get; set; }
}
