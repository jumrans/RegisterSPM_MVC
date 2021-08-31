﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace RegisterSPM.Utility
{
  public static class SessionExtension
  {
    public static void SetObject(this ISession session, string key, object value)
    {
      session.SetString(key, JsonConvert.SerializeObject(value));
    }

    public static T GetObject<T>(this ISession session, string key)
    {
      var value = session.GetString(key);
      return value == null ? default : JsonConvert.DeserializeObject<T>(value);
    }
  }
}