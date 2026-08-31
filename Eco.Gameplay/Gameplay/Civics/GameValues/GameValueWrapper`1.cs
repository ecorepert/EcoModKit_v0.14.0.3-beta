// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueWrapper`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using PropertyChanged;
using System;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[NonSelectable]
[Serialized]
[SerializeForGenericTypes(new Type[] {typeof (User), typeof (IAlias), typeof (bool), typeof (Currency), typeof (BankAccount), typeof (float), typeof (string), typeof (Vector3i), typeof (Settlement), typeof (SimpleEntry), typeof (Deed)})]
public class GameValueWrapper<T> : GameValue<T>
{
  [DependsOn("Object")]
  public override string Title { get; }

  public override LocString Description();

  protected override Eval<T> Evaluate(IContextObject action);

  public override bool IsWrapped { get; }

  [Serialized]
  [ScanProp]
  public T Object { get; set; }
}
