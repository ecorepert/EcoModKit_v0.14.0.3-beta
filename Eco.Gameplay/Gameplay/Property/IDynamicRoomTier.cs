// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.IDynamicRoomTier
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Property;

/// <summary>Implemented by a <see cref="T:Eco.Gameplay.Objects.WorldObjectComponent" /> that contributes a runtime bump to its host's required room material tier (on top of the static <see cref="T:Eco.Gameplay.Property.RequireRoomMaterialTierAttribute" />). The host's bumps are summed and added to the static base when checking <c>room.RoomStats.AverageTier</c>.</summary>
public interface IDynamicRoomTier
{
  /// <summary>Additional tier required on top of the static base. Zero when the component contributes nothing.</summary>
  float MaterialTierBump { get; }
}
