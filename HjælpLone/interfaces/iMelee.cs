using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpLone
{
    interface iMelee : iCharacter
    {
        void Bash();
        void Cleave();
        void Slash();
    }
}
