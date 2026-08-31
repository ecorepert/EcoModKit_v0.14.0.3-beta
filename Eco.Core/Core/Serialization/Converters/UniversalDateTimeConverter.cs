// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Converters.UniversalDateTimeConverter
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

#nullable enable
namespace Eco.Core.Serialization.Converters;

/// <summary>
/// Reads <see cref="T:System.DateTime" /> either with <see cref="T:Newtonsoft.Json.Converters.JavaScriptDateTimeConverter" /> or with <see cref="T:Newtonsoft.Json.Converters.IsoDateTimeConverter" />, but always serializes as <see cref="T:Newtonsoft.Json.Converters.IsoDateTimeConverter" />.
/// Required for transition between old JSON incompatible date serialization format and new ISO JSON compatible format. It will work with old configs, but new configs will be produced in valid format.
/// </summary>
public class UniversalDateTimeConverter : IsoDateTimeConverter
{
  public override object? ReadJson(
    JsonReader reader,
    Type objectType,
    object? existingValue,
    JsonSerializer serializer);
}
