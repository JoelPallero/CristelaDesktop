using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace BackgroundTasksRuntime
{
    [Windows.Foundation.Metadata.ContractVersion(typeof(Windows.Foundation.UniversalApiContract), 65536)]
    [Windows.Foundation.Metadata.Guid(2098451764, 64786, 17358, 140, 34, 234, 31, 241, 60, 6, 223)]
    [Windows.Foundation.Metadata.WebHostHidden]
    public interface IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance);
    }
}
