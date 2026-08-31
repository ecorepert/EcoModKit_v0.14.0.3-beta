// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.AuthDataTrackerComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Tracks object's consumers list and saves it into persistent data. </summary>
[Serialized]
[Priority(200)]
[NoIcon]
public class AuthDataTrackerComponent : WorldObjectComponent, IPersistentData
{
  protected AuthComponent auth;

  public object PersistentData { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [NewTooltipChildren(CacheAs.Instance, TTCat.Controls)]
  public AuthItemData AuthData { get; set; }

  public AuthComponent AuthComponent { get; }

  public override void Initialize();
}
