using Newtonsoft.Json;
using System;

namespace B
{
    public class B
    {
        public string Hoge()
        {
            var c = new C.C()
            {
                Name = nameof(C.C),
            };
            var serialize = JsonConvert.SerializeObject(c);
            return serialize;
        }
    }
}
