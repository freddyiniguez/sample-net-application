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
                Helpers.Utils.RegisterException("CandidatesRepository: GetCandidates", ex.Message);
                return new List<CandidateModel>();
            }
        }


        /// <summary>
        /// GetCandidate()
        /// This method retrieves all information about a specific candidate.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public CandidateModel GetCandidate(int id)
        {
            try
            {
                var _SpResponse = _Context.sp_bios_candidates_getById(id).ToList();
                var _SpResult = _SpResponse.FirstOrDefault();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_bios_candidates_getById_Result, CandidateModel>();
                });
                IMapper LocalMapper = config.CreateMapper();

                CandidateModel Candidate = LocalMapper.Map<sp_bios_candidates_getById_Result, CandidateModel>(_SpResult);

                return Candidate;
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("CandidatesRepository: GetCandidate", ex.Message);
                return new CandidateModel();
            }
        }


        /// <summary>
        /// CreateCandidate()
        /// This method creates a new Candidate with all the required information.
        /// </summary>
        /// <param name="Candidate"></param>
        /// <returns></returns>
        public ResponseModel CreateCandidate(CandidateModel Candidate)
        {
            try
            {
                var _SpResponse = _Context.sp_bios_candidates_create(
                    Candidate.FirstName,
                    Candidate.SecondName,
                    Candidate.LastName,
                    Candidate.SecondLastName,
                    Candidate.FirstName + Candidate.LastName,
                    Candidate.BirthDate,
                    Candidate.Email,
                    Candidate.Phone,
                    Candidate.Cellphone,
                    Candidate.FOJ,
                    Candidate.Location,
                    Candidate.Site,
                    Candidate.Market,
                    "new;candidate;nearshore;").ToList();
                var _SpResult = _SpResponse.FirstOrDefault();

                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<sp_bios_candidates_create_Result, ResponseModel>();
                });
                IMapper LocalMapper = config.CreateMapper();

                ResponseModel Response = LocalMapper.Map<sp_bios_candidates_create_Result, ResponseModel>(_SpResult);

                return Response;
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("CandidateRespository: CreateCandidate", ex.Message);
                return Helpers.ResponseFactory.Create(false);
            }
        }
    }
}