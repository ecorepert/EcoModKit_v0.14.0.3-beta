// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.SimpleEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;
using System.Diagnostics;

#nullable enable
namespace Eco.Gameplay.Utils;

[Serialized]
[HasIcon(null)]
[IconGroup("Types")]
[DebuggerDisplay("{Name}")]
public abstract class SimpleEntry : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  INotifyPropertyChanged,
  ILinkable,
  ILinkableParameterized<bool>,
  ILinkableParameterized<SimpleEntry.NamingOptions>,
  IValidity,
  ICachesValidity,
  IDescribable,
  ISuffixName,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  [Sort(-1f)]
  [LocDescription("A helpful player-created description explaining the purpose of this object for other players.")]
  [UITypeName("StringDescription")]
  public 
  #nullable disable
  string UserDescription { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [Sort(-1f)]
  [DontClone]
  [EcoTextLimit(EcoTextLimitAttribute.TextRangeStyle.Title)]
  public virtual string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [DependsOnSubMember("Creator", "Name")]
  [AllowNullInView]
  public User Creator { get; set; }

  [Serialized]
  [DontClone]
  [Notify]
  public string NameSuffix { get; set; }

  [Serialized]
  public double CreationTime { get; set; }

  [Notify]
  public Result CachedValidity { get; set; }

  [SyncToView(null, true)]
  public bool IsDestroyed { get; }

  public ThreadSafeAction<bool> OnValidityChanged { get; set; }

  public bool Initialized { get; }

  [SyncToView(null, true)]
  [DependsOn("Name", new string[] {"NameSuffix"})]
  public virtual LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  [DontClone]
  [DoNotNotify]
  public int Id { get; }

  [SyncToView(null, true)]
  public virtual string IconName { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public virtual LocString Description();

  [OnPostLoad]
  public void PostLoad();

  public IRegistrar Registrar { get; }

  public double WorldTimeSinceCreation { get; }

  public virtual bool CanBeDeleted { get; }

  protected virtual LocString TextName { get; }

  public bool Scannable { get; set; }

  [Notify]
  public virtual LocString CreatorText(Player reader);

  public override string ToString();

  public void SaveInRegistrar();

  public virtual LocString UILinkContent();

  public virtual LocString UILinkContent(bool param);

  public virtual LocString UILinkContent(SimpleEntry.NamingOptions param);

  public virtual Text.Styles Style { get; }

  public virtual void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public virtual void Initialize();

  public virtual void ReInitialize();

  public virtual void MarkDirty();

  public virtual void Destroyed();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public Result TrueResult { get; set; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public virtual event PropertyChangedEventHandler PropertyChanged;

  public enum NamingOptions
  {
    NoSuffix,
  }
}
