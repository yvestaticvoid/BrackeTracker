using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackeTrackerLibrary
{
    public class TournamentModel
    {
        public string Name { get; set; }
        public List<TeamModel> TournamentTeams { get; set; } = new List<TeamModel>();   
        public decimal EntryFee { get; set; }
        public List<PrizeModel> TournamentPrizes { get; set; } = new List<PrizeModel>();
        public List<List<MatchupModel>> matchupModels { get; set; } = new List<List<MatchupModel>>
    }
}
