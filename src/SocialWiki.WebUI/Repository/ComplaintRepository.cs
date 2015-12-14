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
    public class ComplaintRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Complaint";
        public IMongoCollection<Complaint> Collection;

        //Constructor
        public ComplaintRepository()
        {
            this.Collection = _repo.Db.GetCollection<Complaint>(_collectionName);
        }

        public void Add(Complaint complaint)
        {
            this.Collection.InsertOneAsync(complaint);
        }

        public void Remove(string id, Complaint complaint)
        {
            complaint.Id = new ObjectId(id);
            var filter = Builders<Complaint>.Filter.Eq(s => s.Id, complaint.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Complaint> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Complaint Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Complaint complaint)
        {
            complaint.Id = new ObjectId(id);

            var filter = Builders<Complaint>.Filter.Eq(s => s.Id, complaint.Id);
            this.Collection.ReplaceOneAsync(filter, complaint);
        }
    }
}
