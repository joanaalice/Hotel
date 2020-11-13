﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class QueryResponse<T> : Response
    {
        public QueryResponse()
        {
            this.Data = new List<T>();
        }
        public List<T> Data { get; set; }
    }
}
