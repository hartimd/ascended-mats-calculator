using System.Collections.Generic;

namespace Asc_Mats_Form
{
    public class API
    {
        public int id
        {
            get;
            set;
        }

        public Dictionary<string, int> buys
        {
            get;
            set;
        }

        public Dictionary<string, int> sells
        {
            get;
            set;
        }
    }
}

//{
//    "id": 19684,
//    "buys": {
//        "quantity": 145975,
//        "unit_price": 7018
//    },
//    "sells": {
//        "quantity": 126,
//        "unit_price": 7019
//    }
//}