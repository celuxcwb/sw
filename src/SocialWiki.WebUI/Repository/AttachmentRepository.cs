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
    public class AttachmentRepository 
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Attachment";
        public IMongoCollection<Attachement> Collection;

        //Constructor
        public AttachmentRepository()
        {
            this.Collection = _repo.Db.GetCollection<Attachement>(_collectionName);
        }

        public void Add(Attachement attachment)
        {
            this.Collection.InsertOneAsync(attachment);
        }

        public void Remove(string id, Attachement attachment)
        {
            attachment.Id = new ObjectId(id);
            var filter = Builders<Attachement>.Filter.Eq(s => s.Id, attachment.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Attachement> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Attachement Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Attachement attachment)
        {
            attachment.Id = new ObjectId(id);

            var filter = Builders<Attachement>.Filter.Eq(s => s.Id, attachment.Id);
            this.Collection.ReplaceOneAsync(filter, attachment);
        }
    }
}
