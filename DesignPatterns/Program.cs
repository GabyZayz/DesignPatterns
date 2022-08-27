
using DesignPatterns.BuilderPattern;
using DesignPatterns.FactoryPattern;
using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.UnitOfWorkPattern;

namespace DesignPatterns
{
    class Program
    {


        static void Main(string[] args)
        {

            var customerContest = new CustomerContext();

            Console.WriteLine(customerContest.GetState());

            customerContest.Request(100);

            Console.WriteLine(customerContest.GetState());

            customerContest.Request(50);
            Console.WriteLine(customerContest.GetState());

            customerContest.Request(150);
            Console.WriteLine(customerContest.GetState());

            customerContest.Request(50);
            Console.WriteLine(customerContest.GetState());

            customerContest.Request(50);
            Console.WriteLine(customerContest.GetState());

            /* var builder = new PreparedAlchoholicDrinkConcreteBuilder();

             var barmanDirector = new BarmanDirector(builder);

             barmanDirector.PreparedMargarita();

             var preparedDrink = builder.GetPreparedDrink();

             Console.WriteLine(preparedDrink.Result);

            /* var context = new Context(new CarStrategy());
             context.Run();

             context.Strategy = new MotoStrategy();
             context.Run();

             context.Strategy = new BicycleStrategy();
             context.Run();
            */
            //var log = Singleton.Log.Instance;
            //log.Save("a");

            /*SaleFactory storeSaleFactory = new StoreSaleFactory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(2);

            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);
            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(2);*/

            //dependency injection
            /*  using (var context = new DesignPatternsContext())
              {
                  var unitOfWork = new UnitOfWork(context);

                  var beers = unitOfWork.Beers;

                  var beer = new Beer()
                  {
                      Name = "Fuller",
                      Style = "Porter"
                  };
                  beers.Add(beer);

                  var brands = unitOfWork.Brands;
                  var brand = new Brand()
                  {
                      Name = "Fuller"
                  };
                  brands.Add(brand);

                  unitOfWork.Save();

                  var beerRep = new BeerRepository(context);

              }*/


            // var beerRep = new Repository<Beer>(context);
            //how to remove
            //beerRep.Delete(4);


            // how to save
            //var beer = new Beer() { Name = "Fuller", Style = "Strong Ale" };
            // beerRep.Add(beer);
            // beerRep.Save();

            //foreach (var b in beerRep.Get())
            //{
            //  Console.WriteLine($"{b.BeerId}{b.Name}");
            //}

            /* var beerRep = new BeerRepository(context);
             var beer = new Beer();
             beer.Name = "Corona";
             beer.Style = "Pilsner";
             beerRep.Add(beer);
             beerRep.Save();

             foreach (var b in beerRep.Get())
             {
                 Console.WriteLine(b.Name);
             }*/


            //var beer = new Beer("Pikantus", "Erdinger");
            //var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
            //drinkWithBeer.Build();



        }
    }
}