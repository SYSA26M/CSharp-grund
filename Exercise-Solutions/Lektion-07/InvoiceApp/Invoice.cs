namespace InvoiceApp;

public class Invoice(string paymentMethod)
{
    // Gömd för omvärlden
    // Backing field
    private readonly string _invoiceNumber = Guid.NewGuid().ToString();

    // Property - Egenskap
    public string InvoiceNumber
    {
        get { return _invoiceNumber; }
        // set{}
    }

    // DateTime invoiceDate;
    public DateTime InvoiceDate { get; private set; }
    // string paymentMethod;
    public string PaymentMethod { get; private set; } = paymentMethod;
}
