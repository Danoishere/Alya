﻿using Alya.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Alya.DataAccess;

namespace Alya.WebAPI
{
    public class AlyaApiRepositoryController<TEntityBase> : ApiController where TEntityBase : EntityBase
    {
        public IRepository<TEntityBase> Repository { get; set; } = RepositoryFactory.Create<TEntityBase>();

        [HttpPost]
        [Route]
        public async Task<IHttpActionResult> Insert(TEntityBase entity)
        {
            await Repository.Insert(entity);
            return Ok(entity);
        }

        [HttpPut]
        [Route]
        public async Task<IHttpActionResult> Update(TEntityBase entity)
        {
            await Repository.Update(entity);
            return Ok(entity);
        }


        [HttpDelete]
        [Route("{entityId}")]
        public async Task<IHttpActionResult> Delete(int entityId)
        {
            await Repository.DeleteById(entityId);
            return Ok(true);
        }

        [HttpGet]
        [Route("{entityId}")]
        public async Task<IHttpActionResult> GetById(int entityId)
        {
            var entity = await Repository.GetById(entityId);
            return Ok(entity);
        }

        [HttpGet]
        [Route]
        public async Task<IHttpActionResult> GetAll()
        {
            var entities = await Repository.GetAll();
            return Ok(entities);
        }

        [HttpGet]
        [Route("filter={filterString}")]
        public async Task<IHttpActionResult> GetFiltered(string filterString)
        {
            var entities = await Repository.GetAll();
            return Ok(entities);
        }


        [HttpGet]
        [Route("count={amount}")]
        public async Task<IHttpActionResult> GetAmount(int amount)
        {
            var entities = await Repository.GetAll();
            return Ok(entities);
        }
    }
}
