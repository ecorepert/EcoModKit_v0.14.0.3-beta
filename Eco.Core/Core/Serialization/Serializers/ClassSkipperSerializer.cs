// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ClassSkipperSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System.IO;

#nullable disable
namespace Eco.Core.Serialization.Serializers;

internal class ClassSkipperSerializer : ObjectSerializer, IInitializableSerializer, ISerializer
{
  public ClassSkipperSerializer(
    MigrationManager migrationManager,
    SimpleSerializer parent,
    SerializerSchema schema);

  public void Initialize();

  protected internal override object DecodeInstance(BinaryReader reader);

  protected internal override void SkipInstance(BinaryReader reader);

  protected internal override void EncodeInstance(
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);
}
