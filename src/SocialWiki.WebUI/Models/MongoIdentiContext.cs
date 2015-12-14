using AspNet.Identity3.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;

namespace SocialWiki.WebUI.Models
{
    public class MongoIdentyContext : MongoIdentityContext<ApplicationUser, IdentityRole>
    {
        public MongoIdentyContext()
            : base()
        {
         
             
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "sw";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
    
            this.Users = database.GetCollection<ApplicationUser>("users");
            this.Roles = database.GetCollection<IdentityRole>("roles");

        }
    }
   
}