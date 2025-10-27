

namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;

//using System.Collections.Generic;

internal class Sale_Implementation : ISale
{
    //3.	מימוש מחלקות הגישה לנתונים בפרויקט DalList:
    //    שימו לב! תפקיד מחלקות הגישה בשכבת DAL הוא לאפשר גישה לנתונים בלבד, ע"י פעולות CRUD.
    //הלוגיקה היחידה שתהיה מותרת בשכבה זו היא:
    //1.	בדיקת תקינות של מזהה(וידוא שלא קיים בהוספה או וידוא שקיים בשליפה, עדכון ומחיקה)
    //2.	סינון לפי פילטר המועבר משכבה עליונה(שייך לשלב מתקדם יותר)
    //אסור לבצע בשכבה זו שום לוגיקה נוספת, כגון בדיקות קלט, או פעולות קלט/פלט.
    public int Create(Sale item)
    {
        LogManager.Enter();

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");

        Sale sale = item with { SaleId = DataSource.Config.CodeSale };
        DataSource.sales.Add(sale);
        Tools.LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "create sale");
        LogManager.Exit();
        return sale.SaleId;
        //var q = DataSource.sales.Any(s => s.ProductId == item.ProductId);
        //if (q)
        //    throw new DalIdExistsException("The customer is exists");
        //else
        //{
        //    DataSource.sales.Add(item);
        //    return item.ProductId;
        //}
    }

    public void Delete(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");

        Sale s = Read(id);
        DataSource.sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "delete sale");
        LogManager.Exit();
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

        Sale sale = DataSource.sales.FirstOrDefault(c => filter(c));
        if (sale == null)
        {
            LogManager.Exit();
            throw new DalIdNotExistsException("The sale is not exists");
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
        LogManager.Exit();
        return sale;
    }
    //public Sale? Read(int id)
    //{
    //    LogManager.Enter();
    //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

    //    Sale sale = DataSource.sales.FirstOrDefault(s => s.SaleId == id);
    //    if (sale.SaleId != id)
    //    {
    //        LogManager.Exit();
    //        throw new DalIdNotExistsException("The sale is not exists");
    //    }
    //    LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
    //    LogManager.Exit();
    //    return sale;
       
    //}
    public Sale? Read(int id)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");

        Sale? sale = DataSource.sales.FirstOrDefault(s => s.SaleId == id);
        if (sale == null) // <-- כאן התיקון
        {
            LogManager.Exit();
            throw new DalIdNotExistsException("The sale is not exists");
        }

        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read sale");
        LogManager.Exit();
        return sale;
    }
    public List<Sale?> ReadAll(Func<Sale, bool> filter = null)
    {
        LogManager.Enter();
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all sale");

        if (filter == null)
        {
            LogManager.Exit();
            return new List<Sale?>(DataSource.sales);
        }
            
        var q = DataSource.sales.Where(x => filter(x));
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "read all sale");
        LogManager.Exit();
        return q.ToList();
    }

    public void Update(Sale item)
    {
        LogManager.Enter();
       LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");

        Delete(item.SaleId);
        DataSource.sales.Add(item);
       LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "update sale");
        LogManager.Exit();
    }
}
