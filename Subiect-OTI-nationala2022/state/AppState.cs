using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace Subiect_OTI_nationala2022.state
{
    
    public abstract class  AppState
    { 

        public static  Subject<Boolean> showGrid = new Subject<Boolean>();

        public static Subject<Boolean> showHarta = new Subject<Boolean>();

    }
}
