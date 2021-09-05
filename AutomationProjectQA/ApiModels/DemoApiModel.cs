using System.Collections.Generic;

namespace TestsProject.ApiModels
{
    public class DemoObject
    {
        public string id { get; set; }
    }

    public class DemoApiModel
    {
        public IList<DemoObject> response { get; set; }
    }
}
