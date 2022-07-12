using System;
namespace Tools.Earn
{
    public class ForeingEarnFactory : EarnFactory
    {
        private decimal _percentage;
        private decimal _extra;

        public ForeingEarnFactory (decimal percentage, decimal extra)
        {
            _percentage = percentage;
            _percentage = extra;
        }

        public override IEarn GetEarn()
        {
            return new ForeingEarn(_percentage, _extra);
        }
    }
}

