using MuriloSantos.PedidosApp.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MongoDB.Driver;

namespace MuriloSantos.PedidosApp.Infra.Data.Repositories
{
    public abstract class NoSqlRepository<T> : INoSqlRepository<T> where T : class
    {
        protected readonly IMongoDatabase _db;
        private readonly string _nomeColecao;
        public NoSqlRepository(string nomeColecao)
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            _db = client.GetDatabase("PedidosAppMongoDb");
            _nomeColecao = nomeColecao;
        }
        public IEnumerable<T> All()
        {
            return _db.GetCollection<T>(_nomeColecao).Find(a => true).ToList();
        }

        public long Count()
        {
            return _db.GetCollection<T>(_nomeColecao).Find(a => true).Count();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _db.GetCollection<T>(_nomeColecao).Find(predicate).ToList();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _db.GetCollection<T>(_nomeColecao).Find(predicate).FirstOrDefault();
        }

        public void Insert(T entity)
        {
            _db.GetCollection<T>(_nomeColecao).InsertOne(entity);
        }
    }
}
