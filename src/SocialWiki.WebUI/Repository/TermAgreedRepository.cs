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
    public class TermAgreedRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "TermAgreed";
        public IMongoCollection<TermAgreed> Collection;

        //Constructor
        public TermAgreedRepository()
        {
            this.Collection = _repo.Db.GetCollection<TermAgreed>(_collectionName);
        }

        public void Add(TermAgreed termAgreed)
        {
            this.Collection.InsertOneAsync(termAgreed);
        }

        public void Remove(string id, TermAgreed termAgreed)
        {
            termAgreed.Id = new ObjectId(id);
            var filter = Builders<TermAgreed>.Filter.Eq(s => s.Id, termAgreed.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<TermAgreed> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public TermAgreed Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, TermAgreed termAgreed)
        {
            termAgreed.Id = new ObjectId(id);

            var filter = Builders<TermAgreed>.Filter.Eq(s => s.Id, termAgreed.Id);
            this.Collection.ReplaceOneAsync(filter, termAgreed);
        }
    }
}
