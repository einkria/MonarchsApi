using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

using MonarchsApi.Models;
using MonarchsApi.Repositories;

namespace MonarchsApi.Services
{
    public class MonarchsService : IMonarchsService
    {
        private readonly IMonarchsRepository _repository;

        public MonarchsService(IMonarchsRepository repository)
        {
            _repository = repository;
        }

        public IList<Monarch> GetMonarchs()
        {
            return GetAllMonarchs();
        }

        private IList<Monarch> GetAllMonarchs()
        {
            var stringMonarchs = _repository.GetMonarchs();

            if (stringMonarchs == null)
            {
                return null;
            }

            return ConvertFromJsonToMonarchs(stringMonarchs);
        }

        private IList<Monarch> ConvertFromJsonToMonarchs(String stringMonarchs)
        {
            try
            {
                return JsonConvert.DeserializeObject<List<Monarch>>(stringMonarchs);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not convert json to object: " + ex);
            }

            return null;
        }
    }
}
