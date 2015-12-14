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
    public class CategoryRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Category";
        public IMongoCollection<Category> Collection;

        //Constructor
        public CategoryRepository()
        {
            this.Collection = _repo.Db.GetCollection<Category>(_collectionName);
        }

        public void Add(Category category)
        {
            this.Collection.InsertOneAsync(category);
        }

        public void Remove(string id, Category category)
        {
            category.Id = new ObjectId(id);
            var filter = Builders<Category>.Filter.Eq(s => s.Id, category.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Category> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Category Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Category category)
        {
            category.Id = new ObjectId(id);

            var filter = Builders<Category>.Filter.Eq(s => s.Id, category.Id);
            this.Collection.ReplaceOneAsync(filter, category);
        }
    }
}
