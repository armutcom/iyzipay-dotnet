﻿using System.Net.Http;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
   public class ApiTest : IyzipayResource
    {
        public static  Task<IyzipayResource> Retrieve(Options options)
        {
            return new RestHttpClient().Get<IyzipayResource>(options.BaseUrl + "/payment/test");
        }
    }
}