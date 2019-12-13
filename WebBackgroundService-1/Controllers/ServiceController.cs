using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Hosting;
using System.Web.Http;

namespace WebBackgroundService_1.Controllers
{
    public class ServiceName
    {
        public String name;
        public ServiceName(string ServiceNameValue)
        {
            name = ServiceNameValue;
        }
    }
    public class ServiceController : ApiController
    {
        // GET api/values
        public List<ServiceName> Get()
        {
            HostingEnvironment.QueueBackgroundWorkItem(cancellationToken => new Worker().StartProcessing(cancellationToken));
            List<ServiceName> services = new List<ServiceName>();
            services.Add(new ServiceName("sftp"));
            services.Add(new ServiceName("http"));
            services.Add(new ServiceName("https"));



            return services;
        }

        // GET api/values/5
        public string Get(int id)
        {


            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
