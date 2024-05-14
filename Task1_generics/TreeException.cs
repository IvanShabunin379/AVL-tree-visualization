using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_generics
{
    class TreeException : Exception
    {
        //public TreeException() : base() { }
        public TreeException(string msg) : base(msg) { }
        //public TreeException(string str, Exception inner) : base(str, inner) { }
        //protected TreeException(System.Runtime.Serialization.SerializationInfo si,
        //                        System.Runtime.Serialization.StreamingContext sc) : base(si, sc) { }

        //public override string ToString()
        //{
        //    return Message;
        //}
    }
}
