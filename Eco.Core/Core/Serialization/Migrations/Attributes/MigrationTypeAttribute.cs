// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable enable
namespace Eco.Core.Serialization.Migrations.Attributes;

/// <summary>
/// Attribute for marking class as <see cref="T:Eco.Core.Serialization.Migrations.MigrationType" /> (read more about migration types in the <see cref="T:Eco.Core.Serialization.Migrations.MigrationType" /> documentation).
/// Can be used in two ways:
/// - As <see cref="T:Eco.Shared.Serialization.SerializedAttribute" /> type attribute, then the attributed type will be used to represent new type if <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> not specified.
/// The representing type shouldn't exactly match target type, but only have necessary fields. This type may not even existing in final schema, but used as intermediate type
/// (i.e. if you have Schema v1 with type Foo and need to migrate to Schema v3 with type Baz, but in Schema v2 type Foo was renamed to Bar and then to Baz in v3. In this case you may need to migrate first to MigrationType("Bar", SinceVersion=2) and then you will be able to migrate from Bar to Baz for version v3).
/// - As migration class attribute (the type with <see cref="T:Eco.Core.Serialization.Migrations.Attributes.MigrationAttribute" />). In most cases when used with migration <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.TargetSchemaType" /> is same as <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> as well as <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.SinceVersion" />. In that cases you can just use constructor with type parameter which sets <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> to same value as <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.TargetSchemaType" /> and <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.SinceVersion" /> will be used from <see cref="T:Eco.Core.Serialization.Migrations.Attributes.MigrationAttribute" />.
/// It will help to avoid copy paste and potential errors when these values changes not synced.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = true)]
public class MigrationTypeAttribute : Attribute
{
  /// <summary>Schema type for the migration type. May be different from <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> (i.e. class[Foo] as schema type and FooV1 as migration type).</summary>
  public string TargetSchemaType { get; }

  /// <summary>The first version when this type was added. Can't be used with migrations before that version. If not specified then will be populated from <see cref="T:Eco.Core.Serialization.Migrations.Attributes.MigrationAttribute" /> on same type.</summary>
  public double SinceVersion { get; init; }

  /// <summary>The type representing <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" />. May be same as <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.TargetSchemaType" /> or it's simplified version. Also may represent intermediate type which existed between one of previous supported schema versions and latest schema version.</summary>
  public Type? MigrationType { get; init; }

  /// <summary>Sets both <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.TargetSchemaType" /> and <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> from <paramref name="targetType" />.</summary>
  public MigrationTypeAttribute(Type targetType);

  /// <summary>Sets <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.TargetSchemaType" /> from <paramref name="classNameOrSchemaType" />. <see cref="P:Eco.Core.Serialization.Migrations.Attributes.MigrationTypeAttribute.MigrationType" /> should be specified explicitly or will use attributed type.</summary>
  public MigrationTypeAttribute(string classNameOrSchemaType);
}
