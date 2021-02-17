using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ValheimModManagerNet.Injection
{
    class ValheimModManagerStarter
    {
        public static void Start()
        {
            Injector.Run();
        }
    }
}
