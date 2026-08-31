// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.DataExporter
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems;

[LocDisplayName("DataExporter")]
public class DataExporter : ICommandablePlugin, IServerPlugin
{
  public const string ExportDirectoryName = "Exported Data";
  public static List<(string Category, string Column, string Units)> EnvironmentData;

  public override string ToString();

  public string GetCategory();

  public string GetStatus();

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public static void ExportAll();

  public static void ExportActions();

  public static void ExportSpecies();

  public static void ExportEnvironment();

  public static void ExportChatLog();

  public static string ExportSpecies(string name);

  public static string ExportEnvironment(string category, string units, string column = "Climate");

  public static string ExportAction(string action);
}
