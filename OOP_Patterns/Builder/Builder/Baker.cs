using Builder.Entitiyes;
using Builder.Interface;

namespace Builder.Builder
{
    public class Baker
    {
        private IBuilder _typeBread;

        public IBuilder TypeBread 
        {
            set { _typeBread = value; }
        }

        public Bread CreateBread() 
        {
            _typeBread.SerFlour();

            return _typeBread.GetBread();
        }

        public Bread CreateCakeBread()
        {
            _typeBread.SerFlour();
            _typeBread.SetCream();

            return _typeBread.GetBread();
        }



    }
}
