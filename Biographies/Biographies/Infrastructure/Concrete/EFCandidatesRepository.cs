using System.Collections.Generic;
using Biographies.Entities;
using Biographies.Infrastructure.Abstract;
using Biographies.Models;

namespace Biographies.Infrastructure.Concrete
{
    public class EFCandidatesRepository : ICandidatesRepository
    {
        BiosEntities _Context = new BiosEntities();


        public List<CandidateModel> GetCandidates()
        {
            List<CandidateModel> Candidates = new List<CandidateModel>()
            {
                new CandidateModel()
                {
                    IdCandidate = 1,
                    FirstName = "Freddy",
                    LastName = "Iñiguez",
                    SecondLastName = "López",
                    BirthDate = System.DateTime.Now,
                    Email = "iniguez.devt@gmail.com",
                    Phone = "3312362006",
                    Cellphone = "3331143453"
                }
            };

            return Candidates;
        }
    }
}