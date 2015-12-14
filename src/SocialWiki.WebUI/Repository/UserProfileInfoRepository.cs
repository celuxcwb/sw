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
    public class UserProfileInfoRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "UserProfileInfo";
        public IMongoCollection<UserProfileInfo> Collection;

        //Constructor
        public UserProfileInfoRepository()
        {
            this.Collection = _repo.Db.GetCollection<UserProfileInfo>(_collectionName);
        }

        public void Add(UserProfileInfo userProfile)
        {
            this.Collection.InsertOneAsync(userProfile);
        }

        public void Remove(string id, UserProfileInfo userProfile)
        {
            userProfile.Id = new ObjectId(id);
            var filter = Builders<UserProfileInfo>.Filter.Eq(s => s.Id, userProfile.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<UserProfileInfo> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public UserProfileInfo Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, UserProfileInfo userProfileInfo)
        {
            userProfileInfo.Id = new ObjectId(id);

            var filter = Builders<UserProfileInfo>.Filter.Eq(s => s.Id, userProfileInfo.Id);
            this.Collection.ReplaceOneAsync(filter, userProfileInfo);
        }
    }
}
