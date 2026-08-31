// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Currency
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Gameplay.Economy;

[Serialized]
[Ecopedia(null, "Currency", false, true, null)]
[LocDescription("Currency is a societal construct that makes trade easier.")]
public class Currency : 
  SimpleEntry,
  ILinkableParameterized<float>,
  ILinkable,
  ICategorizedEntry,
  IController,
  IViewController,
  IHasUniversalID
{
  [Serialized]
  public CurrencyType CurrencyType { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  Item BackingItem { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public float CoinsPerItem { get; set; }

  [SyncToView(null, true)]
  public bool Backed { get; }

  [SyncToView(null, true)]
  public LocString CategoryName { get; }

  [SyncToView(null, true)]
  public int CategoryPriority { get; }

  protected override LocString TextName { get; }

  public override string IconName { get; }

  public bool IsPlayerCredit { get; }

  public static int PlayerCreditTextLength { get; }

  [SyncToView(null, true)]
  public float Circulation { get; }

  [SyncToView(null, true)]
  public float TotalCurrency { get; set; }

  [RPC]
  internal void ShowCurrencyReport(Player player);

  public void CirculationChanged();

  /// <summary>Coalesces the per-change <see cref="M:Eco.Gameplay.Economy.Currency.CirculationChanged" /> recompute: while the returned scope is open,
  /// affected currencies are recomputed once on dispose instead of on every balance change. Nests safely.
  /// State is [ThreadStatic], so the scope must be opened and disposed on the same thread (callers use a synchronous 'using').</summary>
  public static IDisposable DeferCirculationRecompute();

  public override LocString UILinkContent();

  public LocString UILinkContent(float amount);

  public LocString UILinkContentNoBold(float amount);

  public LocString UILinkContentNoBoldRed(float amount);

  public override void Initialize();

  [Eco.Shared.Serialization.OnDeserialized]
  public void OnDeserialized();

  public void OnGoneForever();

  private sealed class CirculationRecomputeScope : IDisposable
  {
    public void Dispose();
  }
}
