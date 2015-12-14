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
    public class TermRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Term";
        public IMongoCollection<Term> Collection;

        //Constructor
        public TermRepository()
        {
            this.Collection = _repo.Db.GetCollection<Term>(_collectionName);
        }

        public void Add(Term term)
        {
            this.Collection.InsertOneAsync(term);
        }

        public void Remove(string id, Term term)
        {
            term.Id = new ObjectId(id);
            var filter = Builders<Term>.Filter.Eq(s => s.Id, term.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Term> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Term Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Term term)
        {
            term.Id = new ObjectId(id);

            var filter = Builders<Term>.Filter.Eq(s => s.Id, term.Id);
            this.Collection.ReplaceOneAsync(filter, term);
        }
    }
}
