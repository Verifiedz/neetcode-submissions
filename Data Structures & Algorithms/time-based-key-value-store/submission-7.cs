public class TimeMap {

    /*
        tme based kvp structure,  store multiple vals per key at different timestamps
        retrieve k value at certain timestamp

        set() stores a key with val and ts

        get()
            returns a val such that set() was called prev timestamp_prev<= timestamp
            if muliple values return the val with largest previous timestamp
        

        timemap() since one key can map to muliple values and time stamp
        the value entry will take multiple inputs

        we are going to use a dictionary 

        now since we have 2 data types of val per key they need to related together as an entry
        so an obj that we can then use as the entry in to the dictionary

   */
    Dictionary<string, List<Entry>> dict;
    List<Entry> list;
    public class Entry { 
        public int timestamp;
        public string value;

        public Entry(string value, int timestamp){
            this.timestamp = timestamp;
            this.value = value;
        }
    }
    public TimeMap() {
         dict = new Dictionary<string, List<Entry>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        Entry entry = new Entry(value,timestamp);
        if(!dict.ContainsKey(key)){
            dict[key] = new List<Entry> {entry};
        }
        else{
            dict[key].Add(entry);
        }
    }
    
    public string Get(string key, int timestamp) {
        // retur a value such that set was called previously with prev_ts <= ts
        //there could be multiple vals with timestamps, then we return the largest
        //timestamp that we are given is new timestamp
        //entry timestamp is considered old.
         //we only run the binary search if there is multiple vals for a given key

       if(!dict.TryGetValue(key,  out  var listEntry)){
            return "";
       }

        var resindex= BinarySearch(listEntry, timestamp);
        if(resindex == -1) return "";

        return listEntry[resindex].value;
    }


    public int BinarySearch(List<Entry> listentry, int target){
        int left = 0;
        int right = listentry.Count -1;
        int mid = 0;
        int bestindex = 0;
        //["alice", "happy", 1] ,["alice", 2], ["alice", "sad", 3]
        if(target < listentry[0].timestamp){
            return -1;
        }  
        while(left <= right){
            mid = left + (right - left)/2;
           if(listentry[mid].timestamp == target) return mid;
           if(listentry[mid].timestamp < target){
                left = mid + 1;
                bestindex = mid;
            }
            else{
                right = mid - 1;
            }
        }
        return bestindex;
    }
}
