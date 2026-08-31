// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Maintenance.MaintenanceReason
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Maintenance;

/// <summary>Represents a reason for a scheduled maintenance.</summary>
public enum MaintenanceReason
{
  /// <summary>Maintenance reason representing a normal application shutdown. Exists with the value of <see cref="F:Eco.Core.Plugins.ApplicationExitCodes.NormalShutdown" /></summary>
  Shutdown = 0,
  /// <summary>Maintenance reason representing an automatic restart. Exits with the value of <see cref="F:Eco.Core.Plugins.ApplicationExitCodes.ApplicationRestart" /></summary>
  Restart = 3,
  /// <summary>Maintenance reason representing an automatic update. Exits with the value of <see cref="F:Eco.Core.Plugins.ApplicationExitCodes.ApplicationUpdate" /></summary>
  Update = 4,
}
