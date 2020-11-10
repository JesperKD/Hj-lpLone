using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpLone
{
    interface iShieldBearer : iCharacter
    {
        void RaiseShield();
        void ShieldGlare();
    }
}
