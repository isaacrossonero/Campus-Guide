using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPal.Models
{
    public static class SessionHelper
    {
        //Sets an object into a Session Variable
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }


        //Gets Session Variable to Object
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

        //Checks whether Session object with key already exists or not
        public static void SessionExists(this ISession session, string key)
        {
            var exists = session.Get(key);
            if (exists == null)
            {
                throw new ArgumentNullException("No Session of " + key + " Exists");
            }
        }
    }
}
