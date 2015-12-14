using System;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using SocialWiki.WebUI.Models;
using System.Collections.Generic;

namespace SocialWiki.WebUI.Models
{
    public class City
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [Display(Name = "ID do IBGE")]
        public int IBGE { get; set; }
        [Display(Name = "Nome da cidade")]
        public string Name { get; set; }
        [Display(Name = "UF")]
        public string UF { get; set; }
        [Display(Name = "Área Total")]
        public Nullable<double> TOTAL_AREA { get; set; }
        [Display(Name = "População")]
        public Nullable<double> Population { get; set; }
        [Display(Name = "Divisas")]
        public string Geometry { get; set; }
        [Display(Name = "Latitude")]
        public string Lat { get; set; }
        [Display(Name = "Longitude")]
        public string lng { get; set; }
        [Display(Name = "Informações da cidade")]
        public string info_link { get; set; }
    }
}
