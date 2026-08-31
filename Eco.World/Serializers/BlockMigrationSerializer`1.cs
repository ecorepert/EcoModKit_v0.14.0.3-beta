// Decompiled with JetBrains decompiler
// Type: Eco.World.Serializers.BlockMigrationSerializer`1
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Serialization;
using Eco.Core.Serialization.Migrations;
using Eco.Core.Serialization.Serializers;
using Eco.World.Blocks;

#nullable disable
namespace Eco.World.Serializers;

public class BlockMigrationSerializer<T> : ClassMigrationSerializer<T> where T : Block
{
  public BlockMigrationSerializer(
    MigrationManager migrationManager,
    SimpleSerializer parent,
    SerializerSchema schema);

  public override object NewInstance { get; }
}
