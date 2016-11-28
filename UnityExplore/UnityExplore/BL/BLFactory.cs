
using Microsoft.Practices.Unity;
using UnityExplore.App_Start;

namespace UnityExplore.BL
{
    public interface IBLFactory
    {
        IBL CreateBL(string name);
    }
    public class BLFactory : IBLFactory
    {
        public IBL CreateBL(string name)
        {
           return UnityConfig.GetConfiguredContainer().Resolve<IBL>(name);
        }
    }
}