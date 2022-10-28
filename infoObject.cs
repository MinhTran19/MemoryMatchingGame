using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryMatchingGame
{
    
    public class infoObject
    {
        private string userName, rank;
        private int time, miss;

        public infoObject()
        {
            
        }

        public infoObject(string name, string level, int tries, int timePlay)
        {
            UserName = name;
            Rank = level;
            Miss = tries;
            Time = timePlay;
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string Rank
        {
            get { return rank; }
            set { rank = value; }
        }
        public int Miss
        {
            get { return miss; }
            set { miss = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
    }
}
