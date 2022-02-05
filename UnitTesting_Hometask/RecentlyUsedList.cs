using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_Hometask
{
    class RecentlyUsedList
    {

        private List<string> _recentlyUsedList = new List<string>();
        
        
        public void AddRecord(string newRecord)
        {
            if (_recentlyUsedList.Contains(newRecord))
                _recentlyUsedList.Remove(newRecord);
            

            _recentlyUsedList.Add(newRecord);
        }

        public string ReadRecord(int index)
        {
            return _recentlyUsedList.ElementAt(index);
        }
    }
}
