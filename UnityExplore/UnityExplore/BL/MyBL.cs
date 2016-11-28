using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace UnityExplore.BL
{
    public interface IBL
    {
        void DoPrint();
    }
    public class MyBL : IBL
    {
        public void DoPrint()
        {
            Debug.Write("from MyBL");
        }
    }

    public class XBL : IBL
    {
        public void DoPrint()
        {
            Debug.Write("from x");
        }

        public void XPrint()
        {
            Debug.Write("x tt print");
        }
    }
}