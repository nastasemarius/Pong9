using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pong9.Data.Entities;
using Pong9.IRepositories;
using Pong9.IServices;
using Pong9.Services.Helpers;

namespace Pong9.Services
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _matchRepository;

        public MatchService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public ApiResult<List<Match>> GetAllMatches()
        {
            var matches = _matchRepository.GetAllMatches();

            if (matches == null)
            {
                return new ApiResult<List<Match>>(false);
            }

            return new ApiResult<List<Match>>(matches.ToList());
        }

        public ApiResult<Match> GetMatchById(Guid id)
        {
            var match = _matchRepository.GetMatchById(id);

            if (match == null)
            {
                return new ApiResult<Match>(false);
            }

            return new ApiResult<Match>(match);
        }
    }
}
