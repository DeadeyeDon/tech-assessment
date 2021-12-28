public class OrderDetail
{
    public long ID { get; set; }
    public int lineItem { get; set; }
    public string itemName { get; set; }
    public string itemDescription { get; set; }
    public int itemQty { get; set; }
    public decimal itemPrice { get; set; }
    public decimal itemCost { get; set; }
    public decimal itemDiscount { get; set; }
    // order detail status (e.g. PENDING, ORDERED, BACKORDERED, SHIPPED, DELIVERED)
    public string status { get; set; }
    public datetime orderedDate { get; set; }
    public datetime backorderedDate { get; set; }
    public datetime shippedDate { get; set; }
    public datetime deliveredDate { get; set; }
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy {get; set; }
    public datetime modifiedDateUTC { get; set; }
}
