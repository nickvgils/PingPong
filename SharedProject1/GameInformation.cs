using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProject1
{
    [Serializable]
    public class GameInformation
    {

        public int Score { get; set; }
        public string Player1  { get; set; }
        public string Player2 { get; set; }
        public DateTime DateTime { get; set; }

        public GameInformation()
        {
            DateTime = DateTime.Now;
        }
    }
}
