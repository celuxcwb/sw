using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class Attachement
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string URL { get; set; }
        public short AttachementTypeId { get; set; }
        public string DateAdded { get; set; }
        public int UserId { get; set; }
        public System.Guid ComplaintId { get; set; }

        public virtual UserProfile UserProfile { get; set; }
    }
}
