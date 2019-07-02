using System.Collections.Generic;

namespace Biographies.Infrastructure.Abstract
{
    public interface ICandidatesRepository
    {
        IEnumerable<string> GetCandidates();
    }
}
