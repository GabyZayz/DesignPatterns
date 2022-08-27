using System;
namespace DesignPatterns.BuilderPattern
{
    public class BarmanDirector
    {
        private IBuilder _builder;

        public BarmanDirector(IBuilder builder)
        {
            _builder = builder;
        }

        public void setBuilder(IBuilder buidler)
        {
            _builder = buidler;
        }

        public void PreparedMargarita()
        {
            _builder.Reset();
            _builder.SetAlcohol(9);
            _builder.SetWater(30);
            _builder.AddIngredients("2 Limones");
            _builder.AddIngredients("pizca de sal");
            _builder.AddIngredients("1/4 taza de tequila");

            _builder.Mix();
            _builder.Rest(1000);
        }
        

    }
}

