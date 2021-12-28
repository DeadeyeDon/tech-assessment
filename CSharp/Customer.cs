public class Customer
{
    public long ID { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public Address address { get; set; }
    public PhoneNumber phoneNumber {get; set; }
    // customer status (e.g. ACTIVE, INACTIVE, DELETED)
    public string status { get; set; }
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy {get; set; }
    public datetime modifiedDateUTC { get; set; }
}
