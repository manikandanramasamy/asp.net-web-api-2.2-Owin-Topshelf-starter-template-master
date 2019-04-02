using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost
{
    public class OwinService
    {
        private IDisposable _webApp;

        public void Start()
        {
            // TODO:Mani following code required admin rights for vs
            //  _webApp = WebApp.Start<ApiConfiguration>("http://+:9000");

            _webApp = WebApp.Start<ApiConfiguration>("http://localhost:9000");
        }

        public void Stop()
        {
            _webApp.Dispose();
        }
    }
}
