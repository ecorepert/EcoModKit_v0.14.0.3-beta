// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.LegacyTypeSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

/// <summary>Legacy version of <see cref="T:Eco.Core.Serialization.Serializers.TypeSerializer" /> (before 9.6). May be removed after 10.0 release. Last compatible version should be set to at least 3.9201.</summary>
public class LegacyTypeSerializer : ValueSerializer<Type>
{
  public const double TillVersion = 3.9201;

  public LegacyTypeSerializer(MigrationManager manager);

  public override void EncodeValue(BinaryWriter writer, Type? type, SerializeFlags flags);

  public override Type? DecodeValue(BinaryReader reader);

  public override void Skip(BinaryReader reader);
}
