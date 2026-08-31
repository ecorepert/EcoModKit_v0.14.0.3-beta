// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.ShortTypeNameConverter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json;
using System;

#nullable disable
namespace Eco.Core.Serialization;

/// <summary>Custom <see cref="T:Newtonsoft.Json.JsonConverter" /> implementation for short type names.</summary>
/// <remarks>
/// ShortTypeNameConverter overrides the default System.Type json serialization to not include the version number or the public key token
/// (so we can SNK sign the assembly and have serialization still work)
/// otherwise whenever the SNK changes, serialization will fail
/// this only matters on fields of System.Type, and doesn't affect the internal $type that is otherwise serialized
/// </remarks>
public sealed class ShortTypeNameConverter : JsonConverter
{
  public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);

  public override object ReadJson(
    JsonReader reader,
    Type objectType,
    object existingValue,
    JsonSerializer serializer);

  public override bool CanConvert(Type objectType);
}
