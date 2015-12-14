using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class Comentary
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name ="Texto do comentário")]
        public string Text { get; set; }
        [Display(Name = "Data do comentário")]
        public System.DateTime DtCreated { get; set; }
        [Display(Name = "Voto positivo")]
        public int Up { get; set; }
        [Display(Name = "Voto negativo")]
        public int Down { get; set; }
        [Display(Name = "Ativo")]
        public bool Enabled { get; set; }
        //[Display(Name = "Texto do comentário")]
        //public Nullable<System.Guid> ReplyId { get; set; }
        [Display(Name = "Id da reclamação")]
        public string Complaint_Id { get; set; }
        [Display(Name = "ID do Usuário")]
        public string User_Id { get; set; }
        [Display(Name = "ID do solucionador")]
        public string Solver_Id { get; set; }
    }
}
