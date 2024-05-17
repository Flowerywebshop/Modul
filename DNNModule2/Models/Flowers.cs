using DotNetNuke.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

namespace Bce.Dnn.DNNModule2.Models
{
    
        [TableName("Flowers")]
        [PrimaryKey(nameof(FlowerID), AutoIncrement = true)]
        [Cacheable("Flowers", CacheItemPriority.Default, 20)]
        [Scope("ModuleId")]
        public class Flowers
        {
            public int FlowerID { get; set; }

            public string FlowerName { get; set; }

            public decimal Price { get; set; }

        }
    
}