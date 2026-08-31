// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.BulkContextObject
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

/// <summary>
/// Context object with cache, which could be used for example for bulk query data for all users instead of doing query per user.
/// It's useful to save data between evaluations of GameValue, so it will make first all calculations that are needed for all users, and then just return them from cache.
/// Especially useful in case of DB operations: it's too slow to make query per user, so if you can make bulk query with all users once, it will save a lot of time.
/// Implemented because of lag investigation at White Tiger server: it fixes not working civic ticks due to too slow database requests.
/// </summary>
public class BulkContextObject : IContextObject
{
  public Dictionary<object, Dictionary<int, float>> Cache;
}
