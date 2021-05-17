using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21.Proxy
{
    public class RealObject
    {

    }

    public interface IStuffDoer
    {
        void DoStuff() { }
    }

    public class Proxy: IStuffDoer
    {
        private readonly RealObject _stuff;

        public Proxy(RealObject ro)
        {
            _stuff = ro;
        }

        public void DoMoreStuff(IStuffDoer stuff)
        {
            //this._stuff = stuff;
        }
    }

    class ProxyClient
    {

        static void Main()
        {
            Proxy myProxy = new Proxy(new RealObject());
            //myProxy.DoMoreStuff(new IStuffDoer());
        }

        

        

    }
}
