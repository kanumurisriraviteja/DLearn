using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    public abstract class _11AbsLearn
    {
        public void IntrestRate()
        {
            int i = 5;
        }

        public abstract void CreditCard();
    }


    public class FederalBank : _11AbsLearn, _10IntLearn
    {
        public void AddBalance()
        {
            throw new NotImplementedException();
        }

        public override void CreditCard()
        {
            throw new NotImplementedException();
        }

        public void DebitCard()
        {
            throw new NotImplementedException();
        }

        public void WithBalance()
        {
            throw new NotImplementedException();
        }
    }
}
