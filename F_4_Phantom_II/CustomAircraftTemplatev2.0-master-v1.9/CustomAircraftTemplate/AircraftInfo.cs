using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAircraftTemplateF4PII
{
    public class AircraftInfo
    {

        //READ ME, IMPORTANT!!!!!!!!
        //You must change HarmonyId in order for your custom aircraft mod to be compatible with other aircraft mods
        public const string HarmonyId = "luluk.f4pii";

        
        
        //The name of the aircraft specified in the External Vehicle Info Component
       
        public const string vehicleName = "F-4 Phantom II";
       
        //Names of the prefab name you created and the name of the Assetbundle that you created
        public const string AircraftAssetbundleName = "f4pii";
        public const string AircraftPrefabName = "F4PII"; 


    }
}
