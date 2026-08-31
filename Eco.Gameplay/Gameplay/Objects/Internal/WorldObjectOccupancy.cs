// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.Internal.WorldObjectOccupancy
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Objects.Internal;

public static class WorldObjectOccupancy
{
  /// <summary>Adds the needed WorldObjectBlocks at the object's cached WorldOccupancy cells. If there's no room it adds to the closest nearby block.</summary>
  public static bool PlaceWorldObjectBlocks(WorldObject obj, WorldObject attachedToWorldObject);

  public static void RemoveWorldObjectBlocks(WorldObject obj);
}
