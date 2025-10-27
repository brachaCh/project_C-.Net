

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;

internal class SaleImplementation : ISale
{

    //private string path = @"..\xml\sales.xml";
    //public List<Sale> LoadSaleList()
    //{

    //    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    //    List<Sale> sales;
    //    using (StreamReader streamReader = new StreamReader(path))
    //    {
    //        sales = serializer.Deserialize(streamReader) as List<Sale>;
    //    }
    //    if (sales != null)
    //        return sales;
    //    throw new Exception();
    //}

    //public void SaveListSales(List<Sale> sales)
    //{
    //    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    //    using (StreamWriter streamWriter = new StreamWriter(path))
    //    {
    //        if (sales != null)
    //            serializer.Serialize(streamWriter, sales);
    //        //}  productXml.Add(item with { Product_Id = id });
    //        //productXml.Save(path);
    //        //return item.Product_Id;
    //    }
    //}
    //public int Create(Sale item)
    //{
    //    //int id = Config.saleNum;
    //    List<Sale> sales;
    //    sales = LoadSaleList();   // return x with { Count = x.Count - p.Count };
    //    if (sales != null)
    //        sales.Add(item with { SaleId = Config.SaleMinNum });//TODO
    //    SaveListSales(sales);
    //    return item.ProductId;
    //}

    //public void Delete(int id)
    //{

    //    List<Sale> sales = LoadSaleList();
    //    if (sales == null)
    //        throw new Exception();
    //    Sale sale = sales.FirstOrDefault(s => s.SaleId == id);
    //    if (sale == null) throw new Exception();
    //    sales.Remove(sale);
    //    SaveListSales(sales);
    //}

    //public Sale? Read(int id)
    //{
    //    List<Sale?> sales = LoadSaleList();
    //    Sale? sale = sales.FirstOrDefault(s => s.SaleId == id);
    //    return sale;
    //}

    //public Sale? Read(Func<Sale, bool> filter)
    //{
    //    List<Sale?> sales = LoadSaleList();
    //    Sale? sale = sales.FirstOrDefault(filter);//?????
    //    return sale;

    //}

    //public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)//???
    //{
    //    List<Sale?> sales = LoadSaleList();
    //    if (filter != null)
    //        //Ienumerable???
    //        sales = sales.Where(s => filter(s)).ToList();
    //    if (sales == null) throw new Exception();
    //    return sales;

    //}

    //public void Update(Sale item)
    //{
    //    List<Sale> sales = LoadSaleList();
    //    Sale sale = sales.FirstOrDefault(s => s.SaleId == item.SaleId);
    //    if (sale != null)
    //        sales.Remove(sale);
    //    //sales.Add(item);
    //    sales.Add(item with { SaleId = Config.SaleMinNum });
    //    SaveListSales(sales);

    //}
    static string filePath = @"../xml/sales.xml";
    XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
    List<Sale> list;
    public int Create(Sale item)
    {
        int code = Config.SaleMinNum;
        Sale sale = new Sale(code, item.ProductId, item.Price_Sale, item.If_All_Customers, item.Date_Start_Sale, item.Count_Sale, item.Date_End_Sale);
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
            list.Add(sale);
        }
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
        //return item.SaleId;
        return code;
        //return item.ProductId;
    }

    public void Delete(int id)
    {
        List<Sale> list;
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        var toRemove = list.FirstOrDefault(sale => sale.SaleId == id);
        if (toRemove != null)
        {
            list.Remove(toRemove);
        }

        using (StreamWriter sw = new StreamWriter(filePath))
        {
            serializer.Serialize(sw, list);
        }
    }

    public Sale? Read(int id)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        //return list.FirstOrDefault(s => s.ProductId == id);
        return list.FirstOrDefault(s => s.SaleId == id);
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {

        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        return list.FirstOrDefault(filter);
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        using (StreamReader sr = new StreamReader(filePath))
        {
            list = serializer.Deserialize(sr) as List<Sale>;
        }
        if (filter != null)
            return list?.Where(filter!).ToList() ?? throw new Exception();
        return list;
    }

    public void Update(Sale item)
    {
        Delete(item.SaleId);
        Create(item);
    }
}
