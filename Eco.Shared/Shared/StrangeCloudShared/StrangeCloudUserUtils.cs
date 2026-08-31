// Decompiled with JetBrains decompiler
// Type: Eco.Shared.StrangeCloudShared.StrangeCloudUserUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using StrangeCloud.Service.Client.Contracts;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.StrangeCloudShared;

/// <summary>Functions for interfacing with strange cloud that are used by both the client and server.</summary>
public static class StrangeCloudUserUtils
{
  public static IStrangeWorldsConfig StrangeWorldsConfig;
  public static Func<Guid> WorldID;
  public static Func<Guid> WorldOwnerID;

  public static List<StrangeItemInWorld> GetAllowedItems(StrangeUser user);
}
