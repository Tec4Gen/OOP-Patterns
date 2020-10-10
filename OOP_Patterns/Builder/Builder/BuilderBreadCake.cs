using Builder.Entitiyes;
using Builder.Interface;
using System;

namespace Builder.Builder
{
    public class BuilderBreadCake : IBuilder
    {
        private Bread _breadCake;

        public BuilderBreadCake()
        {
            _breadCake = new Bread();
        }
        public void SerFlour()
        {
            _breadCake.Flour = new Flour { Type = "Gold Flour" };
        }

        public void SetCorn()
        {
            throw new NotImplementedException();
        }

        public void SetSalt()
        {
            throw new NotImplementedException();
        }

        public void SetCream()
        {
            _breadCake.Cream = new Cream { Type = "Super cream" };
        }

        public void Reset()
        {
            _breadCake = new Bread();
        }

        public Bread GetBread()
        {
            Bread temp = _breadCake;

            Reset();

            return temp;
        }
    }
}
