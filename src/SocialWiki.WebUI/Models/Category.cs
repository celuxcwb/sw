using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;


namespace SocialWiki.WebUI.Models
{
    public class Category
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name = "Nome da categoria")]
        public string Name { get; set; }
        [Display(Name = "Descrição da categoria")]
        public string Description { get; set; }
        [Display(Name = "URL da Imagem")]
        public string ImageURL { get; set; }
        [Display(Name = "Categorias")]
        public List<Category> Categories;
    }
}
