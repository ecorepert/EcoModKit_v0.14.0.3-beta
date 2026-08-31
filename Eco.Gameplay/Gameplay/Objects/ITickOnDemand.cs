// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.ITickOnDemand
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>Interface for components (and other objects) which may want to have call to <see cref="M:Eco.Gameplay.Objects.ITickOnDemand.TickOnDemand" /> when closest <see cref="M:Eco.Gameplay.Objects.WorldObjectManager.TickAll" /> happens. It it was added within <see cref="M:Eco.Gameplay.Objects.WorldObject.Tick" /> then it will be processed same tick. They may be registered with <see cref="M:Eco.Gameplay.Objects.IWorldObjectManager.AddToTick(Eco.Gameplay.Objects.ITickOnDemand)" />.</summary>
public interface ITickOnDemand
{
  /// <summary>Ticks only when explicitly requested (see <see cref="T:Eco.Gameplay.Objects.ITickOnDemand" /> docs). Returns false if it should be queued again.</summary>
  bool TickOnDemand();

  double NextTickTime { get; }
}
