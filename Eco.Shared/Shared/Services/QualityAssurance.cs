// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.QualityAssurance
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Services;

public static class QualityAssurance
{
  public static bool QaLanguagesEnabled;
  public static bool DisconnectOnMissingRPC;
  public static bool PhysicsErrorDetectionLogsEnabled;
  public static bool DebugLocalizationEnabled;
  public static bool DebugTooltipCache;
  public static bool SyncServerLogToClient;
  public static bool AllowConnectWithVersionMismatch;
  public static bool AllowAllCommands;
  public static bool GlobalRpcRateLimitEnabled;
  public static bool TrackRepeatedValueNotifications;
  public static bool TooltipDebugWatchdog;

  public static LocString Status { get; }

  public static bool Enabled { get; set; }

  public static bool DeveloperFeaturesEnabled { get; set; }

  /// <summary>Log current status of QA mode.</summary>
  public static void LogStatus();

  /// <summary>Log each bool QA option value.</summary>
  public static void LogQaOptions();

  /// <summary>Called on server startup to initialize QA mode status according to build type and passed arguments.</summary>
  public static void Initialize();
}
