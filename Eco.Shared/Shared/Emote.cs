// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Emote
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared;

/// <summary> Emote definition container. Has all the data except animation clip and that is available both server and client. </summary>
public class Emote
{
  public string ID;
  public LocString Name;
  public string[] Commands;
  public string[] ChainingEmoteIDs;
  public EmoteCategory[] Categories;
  public EmoteConfig Config;

  public Emote(
    LocString name,
    string id,
    string[] cmds,
    EmoteCategory[] categories,
    EmoteConfig config);
}
