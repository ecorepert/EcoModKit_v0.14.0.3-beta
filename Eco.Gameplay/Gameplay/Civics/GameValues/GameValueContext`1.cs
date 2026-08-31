// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GameValueContext`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues;

[NonSelectable]
[Serialized]
[ForceCreateView(ViewTypeName = "GameValueContextView")]
[SerializeForGenericTypes(new Type[] {typeof (User), typeof (IAlias), typeof (bool), typeof (Currency), typeof (BankAccount), typeof (float), typeof (string), typeof (Vector3i), typeof (Settlement), typeof (Deed)})]
public class GameValueContext<T> : 
  GameValue<T>,
  IGameValueContext,
  INamed,
  IController,
  IViewController,
  IHasUniversalID
{
  public override string Title { get; }

  public override bool ShowStatus { get; }

  public override LocString Description();

  [Serialized]
  [SyncToView(null, true)]
  public string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string ContextDescription { get; }

  [Serialized]
  public string MarkedUpNameString { get; }

  [SyncToView(null, true)]
  [DependsOn("MarkedUpNameString")]
  public LocString MarkedUpName { get; }

  public string ContextName { get; }

  public GameValueContext();

  /// <summary>We just pass the property that we want to use as context and this construction will get all the necessary values by itself.</summary>
  public GameValueContext(PropertyInfo context);

  public GameValueContext(string contextName, LocString markedUpName, string description = null);

  protected override Eval<T> Evaluate(IContextObject context);

  public override GameValueFlags Flags(IContextObject context);

  public void SetContextChoice(IContextValue context);
}
