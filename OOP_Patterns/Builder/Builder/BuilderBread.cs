using Builder.Entitiyes;
using Builder.Interface;
using System;

namespace Builder.Builder
{
    public class BuilderBread : IBuilder
    {
        private Bread _bread;

        public BuilderBread()
        {
            _bread = new Bread();
        }
        public void SerFlour()
        {
            _bread.Flour = new Flour { Type = "Gold Flour"};
        }

        public void SetCorn()
        {
            throw new NotImplementedException();
        }

        public void SetSalt()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            _bread = new Bread();
        }

        public Bread GetBread() 
        {
            Bread temp = _bread;

            Reset();

            return temp;
        }

        public void SetCream()
        {
            throw new NotImplementedException();
        }
    }
}
