using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bce.Dnn.DNNModule2.Models;
using DotNetNuke.Data;
using DotNetNuke.Framework;

namespace Bce.Dnn.DNNModule2.Components
{
    internal interface IPackagingManager
    {
        IEnumerable<Packaging> GetPackaging();
    }
    internal class PackagingManager : ServiceLocator<IPackagingManager, PackagingManager>, IPackagingManager
    {

        public IEnumerable<Packaging> GetPackaging()
        {
            IEnumerable<Packaging> t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Packaging>();
                t = rep.Get();
            }
            return t;
        }

        public Packaging GetPackaging(int PackagingID, int moduleId)
        {
            Packaging t;
            using (IDataContext ctx = DataContext.Instance())
            {
                var rep = ctx.GetRepository<Packaging>();
                t = rep.GetById(PackagingID, moduleId);
            }
            return t;
        }


        protected override System.Func<IPackagingManager> GetFactory()
        {
            return () => new PackagingManager();
        }
    }
}