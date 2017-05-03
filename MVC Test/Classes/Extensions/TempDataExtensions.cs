using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Test.Classes.Extensions
{
    public static class TempDataExtensions
    {
        public static T Get<T>(this TempDataDictionary tempData)
        {
            object item;
            tempData.TryGetValue(typeof(T).ToGenericTypeString(), out item);
            return item == null ? default(T) : (T)item;
        }

        public static T Get<T>(this TempDataDictionary tempData, string key)
        {
            object item;
            tempData.TryGetValue(key, out item);
            return item == null ? default(T) : (T)item;
        }

        public static T GetAndKeep<T>(this TempDataDictionary tempData)
        {
            var item = Get<T>(tempData);
            Keep<T>(tempData);
            return item;
        }

        public static void Keep<T>(this TempDataDictionary tempData)
        {
            tempData.Keep(typeof(T).ToGenericTypeString());
        }

        public static void Put<T>(this TempDataDictionary tempData, T value)
        {
            tempData[typeof(T).ToGenericTypeString()] = value;
        }

        public static void Put<T>(this TempDataDictionary tempData, string key, T value)
        {
            tempData[key] = value;
        }

        public static bool ContainsKeyFor<T>(this TempDataDictionary tempData)
        {
            return tempData.ContainsKey(typeof(T).ToGenericTypeString());
        }
    }
}