using Serilog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Domain.Helpers
{
    public class CustomHttpClientHandler : HttpClientHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, 
            CancellationToken cancellationToken)
        {
           
            var stopwatch = Stopwatch.StartNew();
            try
            {
                Log.Information("Request started {0} URL {1} ",
                    request.Method.Method,
                    request.RequestUri?.ToString()
                    );
                return SendAsync(request, cancellationToken);
            }
            finally
            {
                stopwatch.Stop();
                Log.Information("Request Finished: {0}  URL {1} - {2} s.",
                    request.Method.Method,
                    request.RequestUri?.ToString(),
                    stopwatch.Elapsed.TotalSeconds
                    );
            }

            return SendAsync(request, cancellationToken);
        }


    }
}
