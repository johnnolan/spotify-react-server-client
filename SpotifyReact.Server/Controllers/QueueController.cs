using SpotifyReact.Core.Implementations;
using SpotifyReact.Core.Interfaces;
using SpotifyReact.Core.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SpotifyReact.Server.Controllers
{
    public class QueueController : ApiController
    {
        private readonly IQueue queue;

        public QueueController()
        {
            queue = new ElasticsearchQueue();
        }

        // GET api/values 
        public List<Queue> Get()
        {
            return queue.GetQueues();
        }

        // GET api/values/5 
        public List<QueueEntry> Get(Guid id)
        {
            return queue.GetQueueEntries(id);
        }

        // POST api/values 
        public Queue Post([FromBody]string value)
        {
            return queue.CreateNewQueue(value);
        }

        // PUT api/values/5 
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/values/5 
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
