using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;
using MongoDB.Bson;

namespace SocialWiki.WebUI.ViewModels.Solver
{
    public class SolverModel
    {
        public SocialWiki.WebUI.Models.Solver solver{ get; set; } 
        public IList<City> Cities { get; set; }
        public List<BsonDocument> States { get; set; }

    }
}
