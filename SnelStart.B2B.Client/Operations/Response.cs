﻿using System.Net;

namespace SnelStart.B2B.Client.Operations
{
    public class Response
    {
        public HttpStatusCode HttpStatusCode { set; get; }
        public string ResponseBody { set; get; }
    }

    public class Response<T> : Response
    {
        public T Result { get; set; }

    }
}