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
    public class CityRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "City";
        public IMongoCollection<City> Collection;

        //Constructor
        public CityRepository()
        {
            this.Collection = _repo.Db.GetCollection<City>(_collectionName);
        }

        public void Add(City city)
        {
            this.Collection.InsertOneAsync(city);
        }

        public void Remove(string id, City city)
        {
            city.Id = new ObjectId(id);
            var filter = Builders<City>.Filter.Eq(s => s.Id, city.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<City> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public List<BsonDocument> FindAllStates()
        {
            var query = this.Collection.Aggregate().Group(new BsonDocument { { "UF", "$UF" } }).ToListAsync();
            return query.Result;
        }

        public City Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, City city)
        {
            city.Id = new ObjectId(id);

            var filter = Builders<City>.Filter.Eq(s => s.Id, city.Id);
            this.Collection.ReplaceOneAsync(filter, city);
        }
    }
}
