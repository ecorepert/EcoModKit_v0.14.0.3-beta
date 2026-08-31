// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.OnUnownedLand
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.GameActions;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Location")]
[LocDescription("Trigger happened on unowned land.")]
[NoAutogenCode]
[RequiredContext(new Type[] {typeof (IPositionGameAction)})]
public class OnUnownedLand : LocationTest
{
  public override LocString Description();

  public override Eval<bool> CheckLocation(Vector3i pos, IContextObject action);
}
