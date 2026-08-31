// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Disasters.DisasterPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Serialization;
using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Chat;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Disasters;

[LocDisplayName("DisasterPlugin")]
[ChatCommandHandler]
public class DisasterPlugin : 
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IWorkerPlugin,
  IDisplayablePlugin,
  IHasDisplayTabs,
  IDisplayTab
{
  public static 
  #nullable disable
  DisasterSettings Settings { get; }

  public static MeteorObject TheMeteor { get; }

  public static DisasterPlugin.Data MeteorData { get; }

  public IPluginConfig PluginConfig { get; }

  [ChatCommand("Shows commands for manipulations with meteor.", ChatAuthorizationLevel.User)]
  public static void Meteor();

  [ChatSubCommand("Meteor", "Displays status of meteor.", "met", ChatAuthorizationLevel.User)]
  public static void Status(IChatClient chatClient);

  [ChatSubCommand("Meteor", "Adds meteor impact hours", ChatAuthorizationLevel.Admin)]
  public static void AddHours(IChatClient chatClient, float hours);

  [ChatSubCommand("Meteor", "Remove meteor impact hours", ChatAuthorizationLevel.DevTier)]
  public static void RemoveHours(IChatClient chatClient, float hours);

  [CITest(false)]
  [ChatSubCommand("Sim", "Set the percent of a destroyed atmosphere to display, blended to over a given number of seconds.", ChatAuthorizationLevel.DevTier)]
  public static void DestroyedAtmosphere(IChatClient chatClient, float percent = 0.5f, float time = 5f);

  [CITest(false)]
  [ChatSubCommand("Meteor", "Destroys the meteor in orbit.", ChatAuthorizationLevel.Admin)]
  public static void Destroy(IChatClient chatClient);

  [CITest(false)]
  [ChatSubCommand("Meteor", "Spawns a meteor into orbit, regardless of current disaster settings.", ChatAuthorizationLevel.Admin)]
  public static void Spawn(IChatClient chatClient);

  [ChatSubCommand("Meteor", "Begin the meteor impact sequence", ChatAuthorizationLevel.DevTier)]
  public static void Fall(IChatClient chatClient);

  [ChatSubCommand("Meteor", "Make the meteor strike instantly.", ChatAuthorizationLevel.DevTier)]
  public static void Impact(IChatClient chatClient);

  [ChatSubCommand("Meteor", "Make the meteor enter the targetable range, or the specified angle if one is passed in.", ChatAuthorizationLevel.Admin)]
  public static void MakeVisible(IChatClient chatClient, float angle = 300f);

  [CITest(false)]
  [ChatSubCommand("Meteor", "Create a crater at the current position.", ChatAuthorizationLevel.DevTier)]
  public static void SpawnCrater(User user, float size = 5f, bool addPollution = true);

  public static void SpawnCrater(Vector3i hitPos, float craterSize = 5f, bool addPollution = true);

  [ChatSubCommand("Meteor", "Triggers world layers to act as if they were hit by a meteor.", ChatAuthorizationLevel.DevTier)]
  public static void HitWorldLayers();

  [CITest(false)]
  [ChatSubCommand("Meteor", "Makes meteorites rain down the sky, accepting the number to send and how long between them.", ChatAuthorizationLevel.DevTier)]
  public static Task Rain(User user, int count = 1, float timeBetween = 1f, float radius = 20f);

  public static void MeteorRain(
    Vector3 pos,
    int count = 1,
    float timeBetween = 1f,
    float maxDistanceFromImpact = 0.0f);

  public Task DoWork(CancellationToken token);

  public string GetCategory();

  public string GetStatus();

  public override string ToString();

  public object GetEditObject();

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public void OnEditObjectChanged(object o, string param);

  public string GetDisplayText();

  [Serialized]
  public class Data : IStorage, ISerializable
  {
    [Serialized]
    public double MeteorCreationTime;
    [Serialized]
    public double MeteorExtraTime;
    [Serialized]
    public float PercentDestroyedAtmosphere;
    [Serialized]
    public int MeteorRainRemaining;
    [Serialized]
    public float TimeBetweenMeteorRain;
    [Serialized]
    public float MaxDistanceFromImpactPos;
    [Serialized]
    public bool MeteorDestroyed;
    [Serialized]
    public bool MeteorImpacted;
    [Serialized]
    public Vector3 CenterPosition;

    public double ImpactTime { get; }

    IPersistent IStorage.StorageHandle { get; set; }
  }
}
