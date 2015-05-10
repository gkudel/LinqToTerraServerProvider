using LinqToTerraServerProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryableTerraServerData<Place> terraPlaces = new QueryableTerraServerData<Place>();

            string s = "Johannesburg";
            var query = from place in terraPlaces
                        where place.Name == s && place.PlaceType == PlaceType.Island
                        select place.PlaceType;

            foreach (PlaceType placeType in query)
                Console.WriteLine(placeType);
        }
    }
}
