using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRClient
{
    public interface IProgress
    {
        Task ShowProgress(int progress);
    }
}
