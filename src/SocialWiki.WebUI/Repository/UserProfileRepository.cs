using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Repository.Contract;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SocialWiki.WebUI.Repository
{
    public class UserProfileRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "UserProfile";
        public IMongoCollection<UserProfile> Collection;

        //Constructor
        public UserProfileRepository()
        {
            this.Collection = _repo.Db.GetCollection<UserProfile>(_collectionName);
        }

        public void Add(UserProfile userProfile)
        {
            this.Collection.InsertOneAsync(userProfile);
        }

        public void Remove(string id, UserProfile userProfile)
        {
            userProfile.Id = new ObjectId(id);
            var filter = Builders<UserProfile>.Filter.Eq(s => s.Id, userProfile.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<UserProfile> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public UserProfile Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, UserProfile userProfile)
        {
            userProfile.Id = new ObjectId(id);

            var filter = Builders<UserProfile>.Filter.Eq(s => s.Id, userProfile.Id);
            this.Collection.ReplaceOneAsync(filter, userProfile);
        }
    }
}
