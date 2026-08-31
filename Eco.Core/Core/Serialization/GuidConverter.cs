// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.GuidConverter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json;
using System;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary><see cref="T:Newtonsoft.Json.JsonConverter" /> implementation for serializing <see cref="T:System.Guid" /> structs as <see cref="T:System.String" /> objects.</summary>
public class GuidConverter : JsonConverter
{
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer);

  public override bool CanConvert(Type objectType);
}
