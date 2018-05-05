﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurveyAppClassLibrary.Data.Repositories;
using SurveyAppClassLibrary.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SurveyApp2.Controllers
{
    [Route("api/[controller]")]
    public class ClientController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            var clients = unitOfWork.ClientRepository.GetClients();

            return (clients);


            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}