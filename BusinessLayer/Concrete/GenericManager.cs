using BusinessLayer.Interfaces;
using DataAccsessLayer.Interfaces;
using EntityLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity:class,ITable,new()
    {
        private readonly IGenericRepository<TEntity> _repository;

        public GenericManager(IGenericRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Delete(TEntity entity)
        {
            _repository.Delete(entity);
        }

        public TEntity Get(int id)
        {
            return _repository.GetbyId(id);
        }

        public List<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Insert(TEntity entity)
        {
            _repository.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _repository.Update(entity);
        }
    }
}
