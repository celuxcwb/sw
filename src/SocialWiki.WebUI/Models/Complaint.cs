using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class Complaint
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name ="Nome da Reclamação ")]
        public string Name { get; set; }
        [Display(Name = "Descrição")]
        public string Description { get; set; }
        [Display(Name = "Data da criçaõ ")]
        public System.DateTime DtCreation { get; set; }
        [Display(Name = "Data de fechamento")]
        public Nullable<System.DateTime> DtClose { get; set; }
        [Display(Name = "Nome da Solução ")]
        public Nullable<System.DateTime> DtSolve { get; set; }
        [Display(Name = "Cidade")]
        public string City { get; set; }
        [Display(Name = "Estado ")]
        public string UF { get; set; }
        [Display(Name = "Latitude")]
        public string Lat { get; set; }
        [Display(Name = "Longitude")]
        public string Lng { get; set; }
        [Display(Name = "Endereço")]
        public string Address { get; set; }
        [Display(Name = "Pais")]
        public string Country { get; set; }
        [Display(Name = "Voto negativo")]
        public int Down { get; set; }
        [Display(Name = "Voto positivo")]
        public int Up { get; set; }
        [Display(Name = "Solucionado ")]
        public bool Solved { get; set; }
        public string User_Id { get; set; }
        public int Views { get; set; }
        public int Checkins { get; set; }
        public int Shared { get; set; }
        public int Retwitted { get; set; }
        public int SolverId { get; set; }
        public int CategoryId { get; set; }
        public Nullable<bool> Enable { get; set; }

        public  Category category { get; set; }
        public  List<Comentary> Comentaries { get; set; }
        public  ICollection<Comentary> ComplaintAction { get; set; }
        public  ICollection<ComplaintFollow> ComplaintFolow { get; set; }
        public  Solver Solver { get; set; }
        public  UserProfile UserProfile { get; set; }
    }
}

