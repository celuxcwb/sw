using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class Solver
    {
        [BsonId]
        public object Id { get; set; }
        [Display(Name ="Nome do Orgão")]
        public string Name { get; set; }
        [Display(Name = "Descrião da orgão")]
        public string Description { get; set; }
        [Display(Name = "CNPJ do orgão")]
        public string Cnpj { get; set; }
        [Display(Name = "Data de criação")]
        public string CreateDate { get; set; }
        [Display(Name = "Ativo")]
        public Nullable<bool> Active { get; set; }
        [Display(Name = "Url da Imagem")]
        public string Image { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "URL do site do usuário")]
        public string Site { get; set; }
        [Display(Name = "Typo de Orgão")]
        public short SolverTypeId { get; set; }
        [Display(Name = "Tnador")]
        public string Super_Id { get; set; }
        [Display(Name = "Nome da cidade")]
        public string City { get; set; }
        [Display(Name = "Estado")]
        public string UF { get; set; }
        [Display(Name = "Comentários")]
        public List<Comentary> Comentarys { get; set; }
        [Display(Name = "Reclamações")]
        public List<Complaint> Complaints { get; set; }
        [Display(Name = "Solucionadores")]
        public List<Solver> Solvers{ get; set; }
        [Display(Name = "Categorias")]
        public virtual List<Category> Categories { get; set; }
        [Display(Name = "Usuários")]
        public virtual List<UserProfile> UserProfile { get; set; }

    }
}
