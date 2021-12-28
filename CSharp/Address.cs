public class Address
{
    public long ID { get; set; }
    // address type (e.g. 1 = Billing, 2 = Shipping)
    public int type { get; set; }
    public string addressLine1 { get; set; }
    public string addressLine2 { get; set; }
    public string city { get; set; }
    public string state { get; set; }
    public string country { get; set; }
    public string postalCode { get; set; }
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy { get; set; }
    public datetime modifiedDateUTC { get; set; }
}
