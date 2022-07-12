using System;
namespace DesignPatterns.FactoryPattern
{
    //Creator
    public  abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //Concrete creator
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory( decimal extra)
        {
            _extra = extra;

        }
            public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }

   

    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount =  discount;

        }
        public override ISale GetSale()
        {
            return new StoreSale(_discount);
        }
    }

    //Concrete Product
    public class StoreSale : ISale
    {
        private decimal _extra;

        public StoreSale( decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de  {total + _extra}");
        }
    }

    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale()
        {
            _discount = _discount;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de  {total + _discount}");
        }
    }

    //Product
    public interface ISale
    {
      
        public void Sell(decimal total);
    }
}

