// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.TimeUser
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization.Converters;
using Newtonsoft.Json;
using System;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>User which has Date when action can be applied</summary>
public class TimeUser
{
  public TimeUser(string name, DateTime time);

  public TimeUser();

  public string UserName { get; set; }

  [JsonConverter(typeof (UniversalDateTimeConverter))]
  public DateTime ReleaseDate { get; set; }

  public override string ToString();
}
