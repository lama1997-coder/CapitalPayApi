using System;
namespace apiTest.Model
{
    public class ResponseModel
    {
        public object ? data { get; set; }
        public int? statusCode{ get; set; }
        public string? message { get; set; }
        public bool ?status { get; set; }
      
    }
}

