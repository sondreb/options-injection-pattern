using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Hand
{
    public interface IFinger
    {
        void Extend(int extends);

        List<Bone> Joints { get; }
    }
}
