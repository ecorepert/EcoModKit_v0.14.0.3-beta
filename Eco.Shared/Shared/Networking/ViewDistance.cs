// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.ViewDistance
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Networking;

/// <summary><see cref="T:Eco.Shared.Networking.ViewDistance" /> structure used by <see cref="T:Eco.Shared.Networking.IWorldObserver" /> for representing view distance optimized for checks. <see cref="F:Eco.Shared.Networking.ViewDistance.Visible" /> is when object is visible in the view distance and <see cref="F:Eco.Shared.Networking.ViewDistance.NotVisible" /> is when object is out of view distance. It usually higher than <see cref="F:Eco.Shared.Networking.ViewDistance.Visible" /> value to avoid too adding and removing objects in the view.</summary>
public readonly struct ViewDistance
{
  public readonly float Visible;
  public readonly float VisibleSq;
  public readonly float NotVisible;
  public readonly float NotVisibleSq;

  /// <summary>Creates new <see cref="T:Eco.Shared.Networking.ViewDistance" /> with <paramref name="visible" /> distance and <paramref name="invisibilityThreshold" /> when objects in view distance no more visible. <see cref="F:Eco.Shared.Networking.ViewDistance.NotVisible" /> calculated as <see cref="F:Eco.Shared.Networking.ViewDistance.Visible" /> + <paramref name="invisibilityThreshold" />.</summary>
  public ViewDistance(float visible, float invisibilityThreshold);
}
