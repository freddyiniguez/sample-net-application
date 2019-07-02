using Biographies.Infrastructure.Abstract;
using System.Collections.Generic;
using System.Web.Http;

namespace Biographies.Controllers
{
    public class CandidatesController : ApiController
    {
        ICandidatesRepository _ICandidatesRepository;

        // Constructor
        public CandidatesController(ICandidatesRepository iCandidatesRepository)
        {
            _ICandidatesRepository = iCandidatesRepository;
        }

        // GET: api/Candidates
        public IEnumerable<string> Get()
        {
            return _ICandidatesRepository.GetCandidates();
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
