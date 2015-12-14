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
    public class ComplaintFollowRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "ComplaintFollow";
        public IMongoCollection<ComplaintFollow> Collection;

        //Constructor
        public ComplaintFollowRepository()
        {
            this.Collection = _repo.Db.GetCollection<ComplaintFollow>(_collectionName);
        }

        public void Add(ComplaintFollow complaintFollow)
        {
            this.Collection.InsertOneAsync(complaintFollow);
        }

        public void Remove(string id, ComplaintFollow complaintFollow)
        {
            complaintFollow.Id = new ObjectId(id);
            var filter = Builders<ComplaintFollow>.Filter.Eq(s => s.Id, complaintFollow.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<ComplaintFollow> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public ComplaintFollow Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, ComplaintFollow complaintFollow)
        {
            complaintFollow.Id = new ObjectId(id);

            var filter = Builders<ComplaintFollow>.Filter.Eq(s => s.Id, complaintFollow.Id);
            this.Collection.ReplaceOneAsync(filter, complaintFollow);
        }
    }
}
