// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Serializers.TypeMigrationSerializer
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Migrations;
using System;
using System.IO;

#nullable enable
namespace Eco.Core.Serialization.Serializers;

internal class TypeMigrationSerializer : TypeSerializer
{
  public TypeMigrationSerializer(SimpleSerializer parent, MigrationManager migrationManager);

  public override Type? DecodeValue(BinaryReader reader);
}
