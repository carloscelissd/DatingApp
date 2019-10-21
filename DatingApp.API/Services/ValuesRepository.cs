using System.Collections.Generic;
using System.Linq;
using DatingApp.API.Data;
using DatingApp.API.Models;

namespace DatingApp.API.Services
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly DatingAppContext _datingAppContext;
        public ValuesRepository(DatingAppContext datingAppContext)
        {
            _datingAppContext = datingAppContext;
        }
        public List<Values> GetValues()
        {
            return _datingAppContext.Values.ToList();
        }
    }
}