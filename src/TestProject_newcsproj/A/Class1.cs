using System;

namespace A
{
    public class Class1
    {
        public string Hoge()
        {
            return new B.B().Hoge();
        }
    }
}
