using System.Collections.Generic;
using Biographies.Infrastructure.Abstract;

namespace Biographies.Infrastructure.Concrete
{
    public class EFCandidatesRepository : ICandidatesRepository
    {
        public IEnumerable<string> GetCandidates()
        {
            return new string[] { "candidate1", "candidate2" };
        }
    }
}