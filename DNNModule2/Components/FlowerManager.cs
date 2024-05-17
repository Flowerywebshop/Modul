using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bce.Dnn.DNNModule2.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;

namespace Bce.Dnn.DNNModule2.Components
{
    internal interface IFlowersManager
    {
        IEnumerable<Flowers> GetFlowers();
    }
    internal class FlowersManager : ServiceLocator<IFlowersManager, FlowersManager>, IFlowersManager
    {

        public IEnumerable<Flowers> GetFlowers()
        {
            IEnumerable<Flowers> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Flowers>();
                t = rep.Get();
            }
            return t;
        }

        public Flowers GetFlowers(int FlowerID, int moduleId)
        {
            Flowers t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Flowers>();
                t = rep.GetById(FlowerID, moduleId);
            }
            return t;
        }


        protected override System.Func<IFlowersManager> GetFactory()
        {
            return () => new FlowersManager();
        }
    }
}