using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngineApp.Utils
{
    public class ComplimentaryVideoMap
    {
        private static ComplimentaryVideoMap videoMap;
       public Dictionary<string, string> complimentaryVideoMap { get; set; }
        private ComplimentaryVideoMap() {
            complimentaryVideoMap = new Dictionary<string, string>();
            complimentaryVideoMap.Add("Learning to Ski", "First Aid"); }
        public static ComplimentaryVideoMap GetComplimentaryVideoMap()
        {
            if (videoMap != null)
                return videoMap;
            else
            {
                videoMap = new ComplimentaryVideoMap();
                return videoMap; }
              
        }

    }
}
