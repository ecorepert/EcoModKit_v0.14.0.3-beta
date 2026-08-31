// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.IAgingWaste
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>An item whose ground-pollution is delayed by a grace clock (see <see cref="T:Eco.Gameplay.Garbage.WastePollutionAging" />): produced waste is stamped at creation and only pollutes
/// once aged past <see cref="P:Eco.Gameplay.Garbage.IAgingWaste.PollutionGraceDays" />; unstamped waste pollutes immediately. Implementers carry the moment on split and blend it by count on merge.</summary>
public interface IAgingWaste
{
  double CreatedAtSeconds { get; set; }

  float PollutionGraceDays { get; }
}
