// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.VectorConverter
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Newtonsoft.Json;
using System;

#nullable disable
namespace Eco.WebServer;

/// <summary>Custom JsonConverter implementation for handling the serialization/deserialization of Eco Vector datatypes.</summary>
/// <seealso cref="T:Newtonsoft.Json.JsonConverter" />
public class VectorConverter : JsonConverter
{
  public override bool CanConvert(Type objectType);

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer);

  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
}
