using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class UserProfileInfo
    {
        [Display(Name ="Nome do usuário")]
        public string NickName { get; set; }
        [Display(Name ="Nome")]
        public string FirstName { get; set; }
        [Display(Name = "Sobrenome")]
        public string LastName { get; set; }
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        [Display(Name = "RG")]
        public string RG { get; set; }
        [Display(Name = "FotoPerfilURL")]
        public string Picture { get; set; }
        [Display(Name = "Sexo")]
        public string Gender { get; set; }
        [Display(Name = "Data de nascimento")]
        public System.DateTime Bithday { get; set; }
        [Display(Name = "Página pessoal")]
        public string PageLink { get; set; }
        [Display(Name = "E-mail")]
        public string Email { get; set; }
        [Display(Name = "Localização")]
        public string Location { get; set; }
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name = "Primeiro Nome")]
        public string Provider { get; set; }

        public  List<ComplaintAction> ComplaintAction { get; set; }
        public  UserProfile UserProfile { get; set; }
    }
}
