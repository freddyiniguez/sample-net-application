﻿using Biographies.Infrastructure.Abstract;
using Biographies.Models;
using System;
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
        public ResponseModel Get()
        {
            try
            {
                List<CandidateModel> Candidates = _ICandidatesRepository.GetCandidates();

                if (Candidates.Count > 0)
                {
                    ResponseModel SuccessResponse = Helpers.ResponseFactory.Create(true);
                    SuccessResponse.Object = Candidates;
                    return SuccessResponse;
                }

                ResponseModel ErrorResponse = Helpers.ResponseFactory.Create(false);
                ErrorResponse.Message = "No se encontraron resultados.";
                return ErrorResponse;
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("Candidates: Get", ex.Message);
                return Helpers.ResponseFactory.Create(false);
            }
        }

        // GET: api/Candidates/5
        public ResponseModel Get(int id)
        {
            try
            {
                CandidateModel Candidate = _ICandidatesRepository.GetCandidate(id);
                
                if (Candidate.IdCandidate != 0)
                {
                    ResponseModel SuccessResponse = Helpers.ResponseFactory.Create(true);
                    SuccessResponse.Object = Candidate;
                    return SuccessResponse;
                }

                ResponseModel ErrorResponse = Helpers.ResponseFactory.Create(false);
                ErrorResponse.Message = "No se encontraron resultados.";
                return ErrorResponse;
            }
            catch (Exception ex)
            {
                Helpers.Utils.RegisterException("Candidates: Get", ex.Message);
                return Helpers.ResponseFactory.Create(false);
            }
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
