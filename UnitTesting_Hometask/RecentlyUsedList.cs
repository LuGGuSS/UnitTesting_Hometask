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

        public int MaxSize;

        public RecentlyUsedList(){}
        public RecentlyUsedList(int i)
        {
            MaxSize = i;
        }


        public void AddRecord(string newRecord)
        {
            if(_recentlyUsedList.Count == MaxSize && MaxSize!=0)
                _recentlyUsedList.RemoveAt(MaxSize-1);
            if (_recentlyUsedList.Contains(newRecord))
                _recentlyUsedList.Remove(newRecord);
            

            _recentlyUsedList.Insert(0, newRecord);
        }

        public string ReadRecord(int index)
        {
            if ((index >= MaxSize || index < 0)&& MaxSize!=0 )
                throw new IndexOutOfRangeException($"Index {index} is out of bounds.");
            return _recentlyUsedList.ElementAt(index);
        }
    }
}
