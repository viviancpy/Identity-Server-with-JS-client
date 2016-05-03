using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Api
{
    [Route("values")]
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            var random = new Random();

            return new[]
            {
                string.Format("Current Time: {0: dd/MM/yyyy HH:mm:ss}", DateTime.Now),
                random.Next(0, 10).ToString(),
                random.Next(0, 10).ToString()
            };
        }
    }
}