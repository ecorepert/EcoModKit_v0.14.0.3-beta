// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ClassMigrationExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations;

public static class ClassMigrationExtensions
{
  /// <summary>Checks if <see cref="T:Eco.Core.Serialization.Migrations.IClassMigration" /> is compatible with <paramref name="context" />. It compatible if either it's compatible types matches context schema type or reference type name.</summary>
  public static bool IsCompatibleContext(this IClassMigration @this, MigrationContext context);
}
