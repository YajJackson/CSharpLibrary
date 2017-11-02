using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_AccessModifiers
{
    class AccessModifiersClass
    {
        public int PublicProperty { get; set; }
        private int PrivateProperty { get; set; }
        internal int InternalProperty { get; set; }
        protected int ProtectedProperty { get; set; }

    }
}
