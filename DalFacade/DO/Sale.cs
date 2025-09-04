namespace DO;

public record Sale(
    int SaleId,
    int ProductId,
    double Price_Sale,
    bool If_All_Customers,
    DateTime Date_Start_Sale,
    int Count_Sale,
    DateTime? Date_End_Sale = null
)
{
    // קונסטרקטור ריק ל-XmlSerializer
    public Sale() : this(0, 0, 0, true, DateTime.Now, 1, null)
    {
    }

    // קונסטרקטור מותאם ליצירה ידנית
    public Sale(int productId, double price_Sale, bool if_All_Customers,
                DateTime date_Start_Sale, int count_Sale, DateTime? date_End_Sale = null)
        : this(0, productId, price_Sale, if_All_Customers, date_Start_Sale, count_Sale, date_End_Sale)
    {
    }
}
