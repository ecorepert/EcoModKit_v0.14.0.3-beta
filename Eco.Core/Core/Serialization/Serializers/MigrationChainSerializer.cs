// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.MigrationChainSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

public class MigrationChainSerializer : ObjectSerializer, IInitializableSerializer, ISerializer
{
  public MigrationChainSerializer(
    MigrationManager migrationManager,
    SerializerSchema schema,
    double version);

  public MigrationChainSerializer(
    MigrationManager migrationManager,
    ImmutableSerializerSchema schema,
    double version);

  public override void Encode(BinaryWriter writer, object instance, SerializeFlags flags);

  public void Initialize();

  public override string ToString();

  protected internal override DecodedObject DecodeObject(BinaryReader reader, int objTypeId);

  protected internal override void SkipInstance(BinaryReader reader);
}
