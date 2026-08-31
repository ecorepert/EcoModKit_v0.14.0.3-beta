// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.CommandResultV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

/// <summary>Result object from a command execution</summary>
public class CommandResultV1
{
  /// <summary>Represents each returned action/message result from the command</summary>
  public List<CommandMessageV1> CommandMessages;

  /// <summary>Represents the original requested command</summary>
  public string OriginalCommand { get; set; }

  /// <summary>Flag determining if there was an error during execution</summary>
  public bool Errored { get; set; }
}
