// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.GamePickerList
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Civics.GameValues;

/// <summary>Can store a list of IHasID's or a list of Types. A list that can be used to form UI lists of entries for the user to select from. Use <see cref="T:Eco.Gameplay.Civics.GameValues.GamePickerListFactory" /> to create new instance for a base type.</summary>
[Eco.Shared.Networking.Eco(true)]
public class GamePickerList : 
  UnserializedEntry,
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IPostCloneMethodContainer,
  ICloneable
{
  [SyncToView(null, true)]
  [DependsOn("MustDeriveType")]
  public virtual 
  #nullable disable
  string MustDeriveTypeName { get; }

  [Serialized]
  public virtual Type MustDeriveType { get; set; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  [Serialized]
  public string RequiredTag { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  [ScanProp]
  [InheritParentScanProps]
  [TreatAsReference]
  public ControllerHashSet<object> Entries { get; set; }

  [Serialized]
  [Notify]
  public string InternalDescription { get; set; }

  [Serialized]
  protected string DisplayEmptyAs { get; set; }

  public GamePickerList();

  object ICloneable.Clone();

  public GamePickerList(Type baseType, string emptyDesc = null);

  public IEnumerable<T> GetObjects<T>();

  public IEnumerable<Type> GetTypes();

  public void OnCloned();

  protected virtual void EntriesChanged();

  protected virtual void NewEntry(INetObject arg1, object o);

  protected virtual void RemovedEntry(INetObject arg1, object o);

  public void SetSelected(Type entry);

  public Eval<bool> DoEvalType(IEnumerable<object> types);

  public Eval<bool> DoEvalTypes(IEnumerable<object> entries);

  public Eval<bool> DoEvalType(object obj);

  public Eval<bool> DoEval(object entry, bool tryAsType = true);

  public bool ContainsType(Type type);

  public bool ContainsObj(object obj);

  public IEnumerable<string> DescriptionList { get; }

  /// <summary> Returns a hoverable link with entries inside. </summary>
  public string DescribeEntries(LocString joinText);

  public LocString InlineFoldoutListLoc<T>(string itemNounSingular, TooltipOrigin origin = TooltipOrigin.None, int max = 3) where T : ILinkable;

  public override LocString UILinkContent();

  public bool Empty();

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
