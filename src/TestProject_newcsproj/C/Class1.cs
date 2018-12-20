using System;
using System.Reflection;

namespace C
{
    public class C
    {
        public string Name { get; set; }
        public void Hoge()
        {
            var a = Assembly.Load("MessagePack, Version = 1.7.3.4, Culture = neutral, PublicKeyToken = b4a0369545f0a1be");
        }
    }
}
