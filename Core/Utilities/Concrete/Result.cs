using Core.Utilities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Concrete
{
    public class Result : IResult
    {
        // Kullanıcıya mesaj göstermek istemiyorsak opsiyon olarak ikinci constructor'ı ekliyoruz.
        // get read only'dir. read only'ler constructor'larda set edilebilirler.
        public Result(bool success,string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
