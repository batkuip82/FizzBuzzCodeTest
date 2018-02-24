using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientMobile
{
    public interface IFizzBuzzApi
    {
        [Get("/fizzbuzz/{number}")]
        Task<string> Get([AliasAs("number")] int number);
    }
}
