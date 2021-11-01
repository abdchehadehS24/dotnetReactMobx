using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API
{
    public class Config 
    {
        private readonly IConfiguration _config ;

        public Config(IConfiguration config)
        {
            this._config = config;
        }
    }
}