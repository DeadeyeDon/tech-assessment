public class PhoneNumber
{
    public long ID { get; set; }
    // phone number type (e.g. 1 = Home, 2 = Mobile, 3 = Fax)
    public int type { get; set; }
    public string phone { get; set; }
    public string createdBy { get; set; }
    public datetime createdDateUTC { get; set; }
    public string modifiedBy {get; set; }
    public datetime modifiedDateUTC { get; set; }
}
