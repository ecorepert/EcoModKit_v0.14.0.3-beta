// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.SimpleEntryV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Utils;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

/// <summary>A data transfer object wrapper of the Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
/// <seealso cref="T:Eco.Gameplay.Utils.SimpleEntry" />
public class SimpleEntryV1
{
  /// <summary>The unique identifier of this Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
  public int Id { get; set; }

  /// <summary>Name representing this Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
  public string Name { get; set; }

  /// <summary>User description of this Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
  public string UserDescription { get; set; }

  /// <summary>State of this Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
  public string State { get; set; }

  /// <summary>Creator of this Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object.</summary>
  public string Creator { get; set; }

  public SimpleEntryV1();

  /// <summary>Converts an Eco <see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object into a DTO friendly version.</summary>
  /// <param name="entry"><see cref="T:Eco.Gameplay.Utils.SimpleEntry" /> object to convert.</param>
  public SimpleEntryV1(SimpleEntry entry);
}
