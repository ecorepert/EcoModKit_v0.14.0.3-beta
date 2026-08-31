// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.ClassMigrationSerializer`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

public class ClassMigrationSerializer<T> : ClassSerializer<
#nullable disable
T>
{
  protected SerializerSchema schema;

  public ClassMigrationSerializer(
    MigrationManager migrationManager,
    SimpleSerializer parent,
    SerializerSchema schema);

  public override void Initialize();

  internal override void DecodeToInstance(ref object instance, BinaryReader reader);

  /// <summary>
  /// This method's main purpose is to provide access to internal classSerializer.EncodeMembers for migration serializers.
  /// </summary>
  /// <param name="classSerializer">class serializer to be used for members encoding.</param>
  /// <param name="writer">binary writer.</param>
  /// <param name="instance">instance which members will be encoded.</param>
  /// <param name="flags"></param>
  protected void EncodeInstanceWith(
    ClassSerializer classSerializer,
    BinaryWriter writer,
    object instance,
    SerializeFlags flags);

  public override string ToString();
}
