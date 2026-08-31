// Decompiled with JetBrains decompiler
// Type: StrangeCloud.Service.Client.Extensions
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using StrangeCloud.Service.Client.Contracts;
using System;

#nullable enable
namespace StrangeCloud.Service.Client;

public static class Extensions
{
  public static string GetId(this StrangeUser user)
  {
    return !(user.Id != Guid.Empty) ? user.SteamId?.ToString() ?? user.Id.ToString() : user.Id.ToString();
  }
}
