// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RecyclingLinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Dedicated link for a machine's explicit, property-shared connections on objects that may also craft (e.g. the Tool Bench's recycler):
/// keeps them separate from the object's per-user crafting links. Shown in the Recycling tab instead of the Storage tab. </summary>
[Serialized]
[Priority(2147483647 /*0x7FFFFFFF*/)]
[CreateComponentTabLoc("Recycling", false)]
[HasIcon("RecyclingComponent")]
public class RecyclingLinkComponent : SharedLinkComponent
{
  public const string LinkName = "Recycling";

  public override LocString ComponentTabName { get; }
}
