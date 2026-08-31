// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Auth.IAuthChangeListenerComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Property;

#nullable disable
namespace Eco.Gameplay.Components.Auth;

/// <summary>
/// Interface to be used with <see cref="T:Eco.Gameplay.Objects.WorldObjectComponent" />s.  If present, the component
/// will get events from the parent <see cref="T:Eco.Gameplay.Objects.WorldObject" /> about auth ownership changes.
/// </summary>
public interface IAuthChangeListenerComponent
{
  void OnPropertyAuthSet(Deed deed);
}
