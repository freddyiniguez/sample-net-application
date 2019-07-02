using AutoMapper;
using Biographies.Entities;
using Biographies.Infrastructure.Abstract;
using Biographies.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biographies.Infrastructure.Concrete
{
    public class EFCandidatesRepository : ICandidatesRepository
    {
        /// <summary>
        /// Variables
        /// </summary>
        BiosEntities _Context;
        IMapper _IMapper;


        /// <summary>
        /// Constructor
        /// </summary>
        public EFCandidatesRepository()
        {
            _Context = new BiosEntities();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<sp_bios_candidates_get_Result, CandidateModel>();
            });

            _IMapper = config.CreateMapper();

        }


        /// <summary>
        /// GetCandidates()
        /// This method retrieves all registered active candidates.
        /// </summary>
        /// <returns></returns>
        public List<CandidateModel> GetCandidates()
        {
            try
            {
                var _SpResponse = _Context.sp_bios_candidates_get().ToList();

                List<CandidateModel> Candidates = _IMapper.Map<List<sp_bios_candidates_get_Result>, List<CandidateModel>>(_SpResponse);

                return Candidates;
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("GetCandidatesRepository: GetCandidates", ex.Message);
                return new List<CandidateModel>();
            }
        }
    }
}