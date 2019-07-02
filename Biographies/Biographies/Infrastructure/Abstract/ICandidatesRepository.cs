using Biographies.Models;
using System.Collections.Generic;

namespace Biographies.Infrastructure.Abstract
{
    public interface ICandidatesRepository
    {
        List<CandidateModel> GetCandidates();
        CandidateModel GetCandidate(int id);
    }
}
