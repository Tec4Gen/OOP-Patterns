using Adapter.Entityes;
using Adapter.Interface;

namespace Adapter.Adapters
{
    public class AdapterElf : IAttack, IMoving
    {
        private Elf _elf { get;}

        public AdapterElf(Elf elf)
        {
            _elf = elf;
        }
        public void DealDemage()
        {
            _elf.Scream();
            _elf.DealDamage();
        }

        public void Moving()
        {
            _elf.Run();
        }
    }
}
