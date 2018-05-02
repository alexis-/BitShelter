using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPreciousData.Utils
{
  public static class DictionaryEx
  {
    public static T SafeGet<K, T>(this Dictionary<K, T> dic, K key, T defaultRet = default(T))
    {
      if (dic.ContainsKey(key))
        return dic[key];

      return defaultRet;
    }

    public static T SafeGet<K, T>(this ConcurrentDictionary<K, T> dic, K key, T defaultRet = default(T))
    {
      if (dic.ContainsKey(key))
        return dic[key];

      return defaultRet;
    }
  }
}
