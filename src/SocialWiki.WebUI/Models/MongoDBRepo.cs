using MongoDB.Driver;

namespace SocialWiki.WebUI.Models
{

    public class MongoDbRepo
    {
        //The client that manage the connection
        public MongoClient Client;
        //The interface that manage the database
        public IMongoDatabase Db;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url">Mongo server url</param>
        /// <param name="database">Database name</param>
        public MongoDbRepo()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "sw";
            
            this.Client = new MongoClient(connectionString);
            //if the database is not exist, creates the database
            this.Db = this.Client.GetDatabase(databaseName);
        }
    }
}