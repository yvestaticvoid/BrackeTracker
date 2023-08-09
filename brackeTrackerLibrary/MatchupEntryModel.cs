using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brackeTrackerLibrary
{
    public class MatchupEntryModel
    {
        public TeamModel Team { get; set; }
        public double Score { get; set; }
        public MatchupModel ParentMatchup { get; set; }

    }
}
