using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class Term
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name ="Titulo do termo")]
        public string TermsSubjet { get; set; }
        [Display(Name = "Conteúdo do termso")]
        public string TermsContent { get; set; }
        [Display(Name = "Mudança no termo")]
        public short TermsChanges { get; set; }
        [Display(Name = "Data de crição")]
        public System.DateTime TermsCreateDate { get; set; }
        [Display(Name = "Data de alteração")]
        public System.DateTime TermsChangeDate { get; set; }
        [Display(Name = "Termos aceitos")]
        public List<TermAgreed> TermsAgreed { get; set; }
    }
}
