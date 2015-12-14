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
    public class ComplaintActionRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "ComplaintAction";
        public IMongoCollection<ComplaintAction> Collection;

        //Constructor
        public ComplaintActionRepository()
        {
            this.Collection = _repo.Db.GetCollection<ComplaintAction>(_collectionName);
        }

        public void Add(ComplaintAction complaintAction)
        {
            this.Collection.InsertOneAsync(complaintAction);
        }

        public void Remove(string id, ComplaintAction complaintAction)
        {
            complaintAction.Id = new ObjectId(id);
            var filter = Builders<ComplaintAction>.Filter.Eq(s => s.Id, complaintAction.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<ComplaintAction> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public ComplaintAction Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, ComplaintAction complaintAction)
        {
            complaintAction.Id = new ObjectId(id);

            var filter = Builders<ComplaintAction>.Filter.Eq(s => s.Id, complaintAction.Id);
            this.Collection.ReplaceOneAsync(filter, complaintAction);
        }
    }
}
