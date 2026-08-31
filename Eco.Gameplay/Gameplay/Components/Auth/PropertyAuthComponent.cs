// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Auth.PropertyAuthComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Property;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.Auth;

[Serialized]
[HasIcon("AuthComponent")]
public class PropertyAuthComponent : AuthComponent
{
  public override Deed Deed { get; }

  public override void Initialize();

  public override void Destroy();

  public override void OnAfterObjectMoved();

  protected override void OnAuthChanged();

  protected override void OnOwnerChanged(OwnerChangeType changeType);
}
