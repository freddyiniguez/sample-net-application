using System.Collections.Generic;
using System.Web.Http;

namespace Biographies.Controllers
{
    public class CandidatesController : ApiController
    {
        // GET: api/Candidates
        public IEnumerable<string> Get()
        {
            return new string[] { "candidate1", "candidate2" };
        }

        // GET: api/Candidates/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Candidates
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Candidates/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Candidates/5
        public void Delete(int id)
        {
        }
    }
}
