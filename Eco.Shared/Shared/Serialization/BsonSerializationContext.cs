// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BsonSerializationContext
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary> This is used when you send views to some client. Client is necesary to bind to him controllers and to get right value for params PropertyName(Player player).
/// RelatedControllers are used for caching system, so when you cache some view it will be known which exact controllers you should package too (otherwise you could get cached value that refers not-existed at your side controllers). </summary>
public struct BsonSerializationContext
{
  public INetClient? Client;
  public HashSet<int>? RelatedControllers;
}
