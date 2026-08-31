// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.DataTransferObject
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Newtonsoft.Json.Linq;

#nullable enable
namespace Eco.WebServer.DataTransferObjects;

/// <summary>Base class for all data transfer objects used by Eco.</summary>
public class DataTransferObject
{
  /// <summary>Converts this data to a JSON string that can be sent to the SignalR hub.</summary>
  public string ToJson();

  /// <summary>Constructs a new instance of the dataset from its JSON data.</summary>
  /// <typeparam name="TDTO">Dataset model to construct.</typeparam>
  /// <param name="json">Json data to parse.</param>
  /// <returns>Populated dataset model.</returns>
  public static TDTO? FromJson<TDTO>(string json);

  /// <inheritdoc cref="M:Eco.WebServer.DataTransferObjects.DataTransferObject.FromJson``1(System.String)" />
  /// <param name="token"><see cref="T:Newtonsoft.Json.Linq.JToken" /> containined the JSON data.</param>
  public static TDTO? FromJson<TDTO>(JToken token);

  /// <summary>Returns the <see cref="T:Eco.WebServer.DataTransferObjects.DataTransferObject" /> instance as a formatted Json string.</summary>
  /// <returns>Dataset instance serialized to Json.</returns>
  public override string ToString();
}
