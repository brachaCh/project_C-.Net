namespace Dal;
using DO;

internal static class DataSource
{
    internal static List<Customer?> customers = new List<Customer?>();
    internal static List<Product?> products = new List<Product?>();
    //internal static List<Sale?> sales = new List<Sale>();
    internal static List<Sale> sales = new List<Sale>();
    internal static class Config
    {
        // a.שדה מספרי קבוע(const) בהרשאת internal
        // , שיקבל ערך התחלתי למספר הרץ: המספר המזהה הקטן ביותר לפי דרישת כל ישות.
        internal const int ProductMinNum = 100;
    internal const int SaleMinNum = 200;
    //שדה מספרי סטטי בהרשאת private
    //שיקבל כערך התחלתי את השדה הקבוע הקודם.
    private static int ProductNum = ProductMinNum;
    private static int SaleNum = SaleMinNum;
    //b.get	מאפיין עם
    //בלבד שיחזיר את ערך השדה הסטטי ויקדם אותו אוטומטית.
    public static int CodeSale
        {
            get {
                return SaleNum++;
            }         
        }

        public static int CodeProductNum
        {
            get {
                return ProductNum += 10;
            }
      
        }


    }
}
