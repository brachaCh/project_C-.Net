using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;

namespace Bllmplementation
{
    internal class OrderImplementation : IOrder
    {
        //        private DalApi.IDal _dal = DalApi.Factory.Get;
        //        public List<BO.SaleInProduct> AddProductToOrder(Order order, int productId, int countOrder)
        //        {
        //            var product = _dal.Product.Read(productId);
        //            if (product == null)
        //            {
        //                throw new Exception("המוצר לא נמצא");
        //            }
        //            BO.ProductInOrder p = order.ProductList.FirstOrDefault(p2 => p2.Product_Id == productId);
        //            if (p != null)
        //            {
        //                if (p.Count + countOrder > product.Count)
        //                {
        //                    throw new Exception("אין מספיק במלאי");
        //                }
        //                else
        //                {
        //                    p.Count += countOrder;
        //                }

        //            }
        //            else
        //            {
        //                if (product.Count < countOrder)
        //                    throw new Exception("אין מספיק במלאי");
        //                else
        //                {
        //                    ProductInOrder newProduct = new ProductInOrder(product.Product_Id, product.Product_Name, product.Price, countOrder, product.category);
        //                    SearchSaleForProduct(newProduct, order.IsFavoriteCustomer);
        //                    CalcTotalPriceForProduct(newProduct);
        //                    CalcTotalPrice(order);
        //                    return newProduct.sales;
        //                }
        //            }

        //            return p.sales;
        //        }

        //        public void CalcTotalPrice(Order order)
        //        {
        //            order.FinalPrice = order.ProductList.Sum(s => s.Price);
        //        }

        //        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        //        {
        //            int count = productInOrder.Count;
        //            List<SaleInProduct> listSale = new List<SaleInProduct>();
        //            foreach (var item in productInOrder.sales)
        //            {
        //                if (count < item.Count_Sale)
        //                    continue;
        //                productInOrder.TotalPrice += (count / item.Count_Sale) * item.Price_Sale;
        //                count = count % item.Count_Sale;
        //                listSale.Add(item);
        //                if (count == 0)
        //                    break;
        //            }
        //            if (count != 0)
        //            {
        //                productInOrder.TotalPrice = count * productInOrder.Price;
        //            }
        //            productInOrder.sales = listSale;
        //        }

        //        public void DoOrder(BO.Order order)
        //        {
        //            var update = order.ProductList.Select(p =>
        //            {
        //                var x = _dal.Product.Read(p.Product_Id);
        //                if (x.Count < p.Count)
        //                    throw new Exception("אין מספיק מלאי למוצר");
        //                return x with { Count = x.Count - p.Count };
        //            }).ToList();
        //            foreach (var x in update)
        //            {
        //                _dal.Product.Update(x);
        //            }

        //        }


        //        public void SearchSaleForProduct(ProductInOrder productInOrder, bool isFavorite)
        //        {


        //            productInOrder.sales = _dal.Sale.ReadAll(s => (s.ProductId == productInOrder.Product_Id && s.Date_Start_Sale <= DateTime.Now
        //            && s.Date_End_Sale > DateTime.Now && s.Count_Sale <= productInOrder.Count && (!isFavorite && s.If_All_Customers)) || (isFavorite == true))
        //                .Select(s => new BO.SaleInProduct(s.ProductId, s.Count_Sale, s.Price_Sale, s.If_All_Customers))
        //            .OrderBy(s => s.Price_Sale).ToList();


        //        }






        private DalApi.IDal _dal = DalApi.Factory.Get;
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
        {
            var product = _dal.Product.Read(productId);
            if (product == null)
            {
                throw new Exception("המוצר לא נמצא");
            }
            var existingProductInOrder = order.ProductList.FirstOrDefault(p => p.Product_Id == productId);
            if (existingProductInOrder != null)
            {
                if (existingProductInOrder.Count + amount > product.Count)
                {
                    throw new Exception("אין מספיק במלאי");
                }
                existingProductInOrder.Count += amount;
            }
            else
            {
                if (amount > product.Count)
                {
                    throw new Exception("אין מספיק במלאי");
                }
                var newProductInOrder = new BO.ProductInOrder
                {
                    Product_Id = product.Product_Id,
                    Product_Name = product.Product_Name,
                    Count = amount,
                    Price = product.Price
                };
                order.ProductList.Add(newProductInOrder);
                existingProductInOrder = newProductInOrder;
            }
            SearchSaleForProduct(existingProductInOrder, true);
            CalcTotalPriceForProduct(existingProductInOrder);
            CalcTotalPrice(order);
            return existingProductInOrder.sales;
        }


        public void CalcTotalPrice(BO.Order order)
        {
            //order.FinalPrice += (from product in order.ProductList
            //                     select product.Price).Sum();
            order.FinalPrice = order.ProductList.Sum(p => p.TotalPrice);

        }


        public void CalcTotalPriceForProduct(BO.ProductInOrder productForCalc)
        {
            int count = productForCalc.Count;
            double total = 0;
            List<SaleInProduct> usedSales = new List<SaleInProduct>();

            foreach (var sale in productForCalc.sales)
            {
                if (count < sale.Count_Sale)
                    continue;

                int times = count / sale.Count_Sale;
                total += times * sale.Price_Sale;
                count -= times * sale.Count_Sale;
                usedSales.Add(sale);

                if (count == 0)
                    break;
            }
            total += count * productForCalc.Price;
            productForCalc.TotalPrice = total;
            productForCalc.sales = usedSales;
        }


        public void DoOrder(BO.Order order)
        {

            try
            {
                int cnt = order.ProductList
                           .Sum(p => p.Count);
                var update = order.ProductList.Select(p => {
                    var x = _dal.Product.Read(p.Product_Id); if (x.Count < p.Count)
                        throw new Exception("אין מספיק במלאי מהמוצר");
                    return x with { Count = x.Count - p.Count };
                }).ToList();
                foreach (var x in update)
                {
                    _dal.Product.Update(x);
                }

            }
            catch(Exception e) 
            {
                throw new Exception("שגיאה בהזמנה", e);
            }
        }

        public void SearchSaleForProduct(BO.ProductInOrder product, bool isPreferred)
        {
            try
            {
                product.sales = _dal.Sale.ReadAll(s => s.ProductId == product.Product_Id
                && s.Date_Start_Sale <= DateTime.Now && s.Date_End_Sale >= DateTime.Now
                && (isPreferred || s.If_All_Customers))
                    .Select(s => new SaleInProduct() { SaleId = s.SaleId, If_All_Customers = s.If_All_Customers, Price_Sale = s.Price_Sale })
                    .OrderBy(s => s.Price_Sale)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("שגיאה בהזמנה", ex);

            }
        }
    }
}
