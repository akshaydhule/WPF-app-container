using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUI
{
    public class DataEntryCollection
    {
        /// <summary>
        /// Dataentries list for event data display
        /// </summary>
        public ObservableCollection<DataEntries> DataEntrylist { get; set; }

        /// <summary>
        /// Private instance
        /// </summary>
        private static DataEntryCollection _Instance;

        /// <summary>
        /// Public singleton instance
        /// </summary>
        public static DataEntryCollection Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new DataEntryCollection();
                return _Instance;
            }
        }

        /// <summary>
        /// constructor
        /// </summary>
        private DataEntryCollection()
        {
            DataEntrylist = new ObservableCollection<DataEntries>();
        }
    }
}
