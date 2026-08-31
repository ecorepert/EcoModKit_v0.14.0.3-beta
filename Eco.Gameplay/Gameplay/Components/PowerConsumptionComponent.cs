// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PowerConsumptionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (PowerGridComponent), null)]
[Ecopedia(null, "Power Component", false, true, null)]
[CreateComponentTabLoc("Power", false)]
[HasIcon("PowerComponent")]
[ChatCommandHandler]
public class PowerConsumptionComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public float JoulesPerSecond { get; }

  [Serialized]
  public float OverrideJoulesPerSecond { get; }

  public PowerConsumptionComponent();

  public PowerConsumptionComponent(float joulesPerSecond);

  public float BaseJoulesPerSecond { get; }

  public void Initialize(float watts);

  public override void Initialize();

  public void OverridePowerConsumption(float overrideWatts);

  /// <summary> Clears any active power override, restoring grid demand to the base <see cref="F:Eco.Gameplay.Components.PowerConsumptionComponent.joulesPerSecond" />. </summary>
  public void ClearPowerOverride();

  [ChatSubCommand("Craft", "Reduces power consumption of all existing objects withing a given radius to passed value (defaults zero).", ChatAuthorizationLevel.DevTier)]
  public static void SetPowerCost(User user, float cost = 0.0f, float radius = 20f);
}
