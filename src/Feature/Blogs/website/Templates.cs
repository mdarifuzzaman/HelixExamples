using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicCompany.Feature.Blogs
{
    public static class Templates
    {
        public static class Blogs
        {
            public static readonly ID Id = new ID("{D95D9E0B-0EE8-412D-8E42-3C474ED26228}");

            public static class Fields
            {
                public static readonly ID BlogTitle = new ID("{DDAB4A9F-8AB8-4243-8224-1CBADA9168BF}");
                public static readonly ID BlogImage = new ID("{66A1FCEB-DEF9-4DB9-BB44-D365CE43775D}");
                public static readonly ID BlogBody = new ID("{51B7E1CA-E82B-4A4D-92DE-721348870AB0}");
                public static readonly ID BlogAuthor = new ID("{0165BFFD-CB2B-4055-AAED-940271EB75B0}");
            }
        }
    }
}