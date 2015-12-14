using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class TermAgreed
    {
        [Display(Name = "Data de aceite")]
        public System.DateTime TermsAgreedDate { get; set; }
        [Display(Name = "Id do termo")]
        public string Term_Id { get; set; }
        [Display(Name = "Id do usuário")]
        public string User_Id { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name = "Termo")]
        public Term Term { get; set; }
        [Display(Name = "Usuário")]
        public UserProfile UserProfile { get; set; }
    }
}
