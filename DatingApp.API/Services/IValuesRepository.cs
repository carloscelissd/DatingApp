using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.Services
{
    public interface IValuesRepository
    {
        List<Values> GetValues();
    }
}