// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.PointOfInterestManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;

#nullable enable
namespace Eco.Gameplay.Economy;

public static class PointOfInterestManager
{
  public static void AddAsPOI(this 
  #nullable disable
  WorldObject obj, string category);

  public static void RemoveAsPOI(this WorldObject obj, string category);

  public static void UpdateObj(WorldObject obj);

  public static PointOfInterest GetForObj(WorldObject obj);

  public static PointOfInterest GetProperty(Deed deed);

  public static IController GetList(
    string category,
    User owner = null,
    bool excludeZero = true,
    bool excludeEmpty = true);

  internal static void AddDeed(Deed deed);

  internal static void InitProperty();

  public static string EmptyText(string cat);
}
