// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.MemberDataModification
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>Base class for data member modifications (update, add, migrate, remove etc). Used in <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" />.</summary>
public abstract class MemberDataModification : IDataModification
{
  protected readonly MemberDataInput member;
  protected MigrationManager migrationManager;

  protected MemberDataModification(MemberDataInput member);

  public virtual void Initialize(MigrationManager manager);

  /// <summary>Applies member modification to data object context.</summary>
  public void Apply(MigrationContext context);

  /// <summary>Generates data member output value after modification applied.</summary>
  public abstract ReaderDataInput? GenerateOutput(MigrationContext context);
}
