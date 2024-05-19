using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Bce.Dnn.DNNModule2.Models
{
    [TableName("Packaging")]
    [PrimaryKey(nameof(PackagingID), AutoIncrement = true)]
    [Cacheable("Packaging", CacheItemPriority.Default, 20)]
    [Scope("ModuleId")]
    public class Packaging
    {
        public int PackagingID { get; set; }

        public string PackagingName { get; set; }

        public decimal Price { get; set; }

    }
}