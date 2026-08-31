// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.PropertyValues.DeedOwner
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.PropertyValues;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Deeds")]
[LocDescription("Get the owner (citizen or title) of a given deed.")]
public class DeedOwner : DeedGameValue<IAlias>
{
  protected override Eval<IAlias> Evaluate(IContextObject action);

  public override LocString Description();
}
