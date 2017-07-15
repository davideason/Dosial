using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ouvera.Utilities.ModelTracking
{
    internal interface IModelTracker
    {
        void StartTracking();
        void TagDeleted();
    }
}
