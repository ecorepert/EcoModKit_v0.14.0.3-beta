// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.MigrationTypeSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

public class MigrationTypeSerializer : ObjectSerializer, IInitializableSerializer, ISerializer
{
  public MigrationTypeSerializer(
    MigrationManager migrationManager,
    Type migrationType,
    string targetSchemaType);

  public void Initialize();

  protected internal override void EncodeInstance(
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  protected internal override object DecodeInstance(BinaryReader reader);

  protected internal override void SkipInstance(BinaryReader reader);

  public override void Encode(BinaryWriter writer, object instance, SerializeFlags flags);
}
