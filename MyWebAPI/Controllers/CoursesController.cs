﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebAPI.Controllers
{
    public class CoursesController : ApiController
    {
        public List<int> Get()
        {
            List<int> test = new List<int>();
            test.Add(1);
            test.Add(2);
            test.Add(3);

            return test;
        }

    }
}