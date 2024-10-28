using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerJSONDinamico
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Pet
    {
        public string name { get; set; }
        public string species { get; set; }
        public List<string> favFoods { get; set; }
        public int birthYear { get; set; }
        public string photo { get; set; }
    }

    public class Root
    {
        public List<Pet> pets { get; set; }
    }


}
