using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class ComplaintAction
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name ="Id da reclamação")]
        public string Complaints_Id { get; set; }
        [Display(Name = "ID do Usuário")]
        public string User_Id { get; set; }
        [Display(Name = "Data de criação")]
        public Nullable<System.DateTime> DtCreate { get; set; }
        [Display(Name = "Data para solução")]
        public Nullable<System.DateTime> DtForSolution { get; set; }
        [Display(Name = "Data de fechamento")]
        public Nullable<System.DateTime> DtClose { get; set; }
        [Display(Name = "Tipos de aç~~ao")]
        public int ActionTypes { get; set; }
        [Display(Name = "Id de solucionador")]
        public string Solver_Id { get; set; }
        [Display(Name = "ID do comentário")]
        public Nullable<System.Guid> Comentary_Id { get; set; }
        [Display(Name = "Aceito")]
        public Nullable<bool> Acepted { get; set; }
        [Display(Name = "Lido pelo usuário")]
        public Nullable<bool> UserRead { get; set; }
        [Display(Name = "Comentario")]
        public Comentary comentary{ get; set; }
        [Display(Name = "Ação")]
        public ComplaintAction complaintAction { get; set; }
        [Display(Name = "Reclamação")]
        public Complaint Complaint { get; set; }
        public UserProfileInfo userprofileInfo { get; set; }
    }
}
