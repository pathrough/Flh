﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using Flh.Data;
using Newtonsoft.Json;

namespace Flh.AdminSite.Models
{
    public class ClassTreeModel : IClassModel<ClassTreeModel>
    {
        [JsonProperty(PropertyName = "no")]
        public string ClassNo { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string ClassName { get; set; }
        [JsonProperty(PropertyName = "subs")]
       public IEnumerable<ClassTreeModel>Subs { get; set; }
    }

}
