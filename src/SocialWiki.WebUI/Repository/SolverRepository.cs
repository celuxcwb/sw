﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialWiki.WebUI.Models;
using SocialWiki.WebUI.Repository.Contract;
using MongoDB.Driver;
using MongoDB.Bson;

namespace SocialWiki.WebUI.Repository
{
    public class SolverRepository
    {

        internal MongoDbRepo _repo = new MongoDbRepo();
        private const string _collectionName = "Solver";
        public IMongoCollection<Solver> Collection;

        //Constructor
        public SolverRepository()
        {
            this.Collection = _repo.Db.GetCollection<Solver>(_collectionName);
        }

        public void Add(Solver solver)
        {
            if (solver.Id == null)
                solver.Id = ObjectId.GenerateNewId();
            this.Collection.InsertOneAsync(solver);
        }

        public void Remove(string id, Solver solver)
        {
            solver.Id = new ObjectId(id);
            var filter = Builders<Solver>.Filter.Eq(s => s.Id, solver.Id);
            this.Collection.DeleteOneAsync(filter);
        }

        public List<Solver> FindAll()
        {
            var query = this.Collection.Find(new BsonDocument()).ToListAsync();
            return query.Result;
        }

        public Solver Find(string id)
        {
            return this.Collection.Find(new BsonDocument { { "_id", new ObjectId(id) } }).FirstAsync().Result;
        }
        public void Update(string id, Solver solver)
        {
            solver.Id = new ObjectId(id);

            var filter = Builders<Solver>.Filter.Eq(s => s.Id, solver.Id);
            this.Collection.ReplaceOneAsync(filter, solver);
        }
    }
}
