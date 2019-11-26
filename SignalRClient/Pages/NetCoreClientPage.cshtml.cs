using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRClient.Pages
{
    public class NetCoreClientPageModel : PageModel
    {
        readonly ILogger<NetCoreClientPageModel> _logger;
        readonly IProgress _progress;

        //public NetCoreClientPageModel(ILogger<NetCoreClientPageModel> logger,
        //    IProgress progress)
        //{
        //    _logger = logger;
        //    _progress = progress;
        //}

        public void OnGet()
        {
        }
    }
}