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
    public class ComentaryRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Comentary";
        public IMongoCollection<Comentary> Collection;

        //Constructor
        public ComentaryRepository()
        {
            this.Collection = _repo.Db.GetCollection<Comentary>(_collectionName);
        }

        public void Add(Comentary comentary)
        {
            this.Collection.InsertOneAsync(comentary);
        }

        public void Remove(string id, Comentary comentary)
        {
            comentary.Id = new ObjectId(id);
            var filter = Builders<Comentary>.Filter.Eq(s => s.Id, comentary.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Comentary> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Comentary Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Comentary comentary)
        {
            comentary.Id = new ObjectId(id);

            var filter = Builders<Comentary>.Filter.Eq(s => s.Id, comentary.Id);
            this.Collection.ReplaceOneAsync(filter, comentary);
        }
    }
}
