// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.ApplicationExitCodes
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Plugins;

/// <summary>
/// Enum containing all standardized and understood Eco server exit codes. Ranging from 0-255.
/// This Enum contains all options currently used by the Eco server instance. This enum should avoid overlappin with standard application exit codes.
/// </summary>
/// <remarks>
/// Eco specific exit codes should be aware of the reserved exit codes used by various operating systems. A rough layout of these codes is as follows
/// 
/// <list type="bullet">
/// <item>0 - Normal exit.</item>
/// <item>1-2 - Standardized Failure.</item>
/// <item>126 - A command was found but cannot be executed.</item>
/// <item>127 - A command could not be found.</item>
/// <item>128-255 - Failure.</item>
/// <item>256 and above - A command has exited because of reciept of a signal.</item>
/// </list>
/// Eco is free to utilize exit codes between 3 and 125.
/// </remarks>
public enum ApplicationExitCodes
{
  /// <summary>Succesful application termination.</summary>
  NormalShutdown = 0,
  /// <summary>Catchall for general errors.</summary>
  GeneralApplicationError = 1,
  /// <summary>
  /// Exit code 2 signifies invalid usage of some shell built-in command. Examples of built-in commands include.
  /// This is only here to reserve the exit code as Eco Server should never return this code on its own.
  /// </summary>
  [Obsolete("Handled by dotnet. This value still exists purely for id reservation and should not be used.", true)] MisuseOfShellBuiltin = 2,
  /// <summary>Fired off when Eco server attempts to restart. Generally handled by the maintenance plugin.</summary>
  ApplicationRestart = 3,
  /// <summary>Fired off when Eco server attempts to update. Generally handled by the maintenance plugin.</summary>
  ApplicationUpdate = 4,
  /// <summary>Fired off when Eco server starts without proper server credentials.</summary>
  ServerCredentialsMissing = 5,
  /// <summary>Called when the integration test's plugin shuts down the server with an unsuccessful result.</summary>
  IntegrationTestsFailed = 255, // 0x000000FF
}
