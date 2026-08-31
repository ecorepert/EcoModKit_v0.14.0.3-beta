// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.MigrationDataModification
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary><see cref="T:Eco.Core.Serialization.Migrations.DataMigrations.MemberDataModification" /> which applies modification to member with custom <see cref="T:Eco.Core.Serialization.Migrations.IMigration" />.</summary>
/// <inheritdoc cref="T:Eco.Core.Serialization.Migrations.DataMigrations.MemberDataModification" />
public class MigrationDataModification : MemberDataModification
{
  public MigrationDataModification(
    MemberDataInput member,
    IMigration migration,
    bool skipIfMissing);

  public override void Initialize(MigrationManager manager);

  public override ReaderDataInput? GenerateOutput(MigrationContext context);
}
