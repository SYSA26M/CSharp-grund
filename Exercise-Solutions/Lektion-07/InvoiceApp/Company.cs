namespace InvoiceApp;

public class Company
{
    private readonly string _organizationNo;
    public string OrganizationNumber
    {
        get { return _organizationNo; }
    }

    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
    // Farligt och dåligt sätt att hantera ett företags organisationsnummer
    // public string OrganizationNumber { get; private set; } = orgNo;
    public string VATNumber { get; private set; }
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";

    public Company(string orgNo, string vatNo)
    {
        VATNumber = vatNo;
        var isValid = ValidateCompany(orgNo);
        if (!isValid) throw new Exception("Företaget är fejk!");
        _organizationNo = orgNo;
    }

    private bool ValidateCompany(string orgNo)
    {
        // Gör kontroll av organisationnumret
        // Det är OK gå vidare till nästa steg
        // Kontrollera att företag existerar i Sverige...
        // Om allt är ok return sant(true)
        // Annars returnera falskt(false)
        return true;
    }
}
