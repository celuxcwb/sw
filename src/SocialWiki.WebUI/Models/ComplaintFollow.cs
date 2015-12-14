using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class ComplaintFollow
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name = "Id do usuário")]
        public Nullable<int> User_Id { get; set; }
        [Display(Name = "Id da reclamação")]
        public Nullable<System.Guid> Complaints_Id { get; set; }
        [Display(Name = "Reclamação")]
        public Complaint Complaint { get; set; }
        [Display(Name = "Perfil do Usuário")]
        public UserProfile UserProfile { get; set; }
    }
}
