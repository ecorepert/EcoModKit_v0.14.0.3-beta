// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.SelectString
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Serialized]
[NonSelectable]
public class SelectString : TriggerConfig
{
  [Eco.Shared.Networking.Eco(true)]
  [Eco.Core.Controller.DynamicTitle("DynamicTitle")]
  [AllowNullInView]
  public string String { get; set; }

  public override LocString Description();

  public SelectString();

  public SelectString(Type type, PropertyInfo prop);

  protected override Eval<bool> Evaluate(IContextObject context);
}
