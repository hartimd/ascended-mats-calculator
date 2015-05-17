using System.Collections.Generic;

namespace AscendedMaterialsForm
{
    public class API
    {
        public int id
        {
            get;
            set;
        }

        public Dictionary<string, int> Buys
        {
            get;
            set;
        }

        public Dictionary<string, int> Sells
        {
            get;
            set;
        }
    }
}