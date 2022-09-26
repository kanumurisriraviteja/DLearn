using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Core
{
    abstract class _11AbsLearn : _10IntLearn
    {
        int i = 5;
        public void IntrestRate()
        {
            i = 5;
            Console.Write(_10IntLearn.iVar);
        }

        private void Test() { }
        public abstract void CreditCard();
        public abstract void AddBalance();
        public abstract void WithBalance();
        public abstract void DebitCard();
    }


    class FederalBank : _11AbsLearn
    {
        public override void AddBalance()
        {
            throw new NotImplementedException();
        }

        public override void CreditCard()
        {
            throw new NotImplementedException();
        }

        public override void DebitCard()
        {
            throw new NotImplementedException();
        }

        public override void WithBalance()
        {
            throw new NotImplementedException();
        }
    }
}
