// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.IsOnOwnedDeed
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Deeds")]
[LocDescription("True if a given location is on a deed owned by the given citizen or title.")]
public class IsOnOwnedDeed : GameValue<bool>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The location to check.")]
  public GameValue<Vector3i> Location { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen or title to check ownership for.")]
  public GameValue<IAlias> Owner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Whether to check direct ownership, member ownership, or both.")]
  public DeedOwnershipType OwnershipType { get; set; }

  protected override Eval<bool> Evaluate(IContextObject action);

  public override LocString Description();
}
