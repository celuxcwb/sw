using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class UserProfile
    {
        public ObjectId Id { get; set; }
        public List<Attachement> Attachements { get; set; }
        public List<Comentary> Comentaries { get; set; }
        public List<ComplaintFollow> ComplaintFolow { get; set; }
        public List<Complaint> Complaint { get; set; }
        public List<TermAgreed> TermsAgreed { get; set; }
        public  UserProfileInfo UserInfo { get; set; }
        public  List<Solver> Solvers { get; set; }
    }
}
