// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Constitutional.CivicArticleCondition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics.Constitutional;

/// <summary>Defines a type of civic action, which can be used to determine government rules in a constitution via CivicArticles</summary>
[Serialized]
[ForceCreateView]
public abstract class CivicArticleCondition : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IValidity,
  IDescribable
{
  public event PropertyChangedEventHandler PropertyChanged;

  public virtual Type AppliesToType { get; }

  public bool Applies(Type type);

  public virtual LocString Description();

  public virtual LocString DescribeAction(Type type);

  public virtual LocString ActionPrefix { get; }

  /// <summary>Returns true if this civic condition matches the given action (either because it applies to the type of civic action, or its acting on a container of the given type of civic types.)</summary>
  public virtual bool PassesCondition(User user, CivicAction action);

  [DoNotNotify]
  public ref int ControllerID { get; }
}
