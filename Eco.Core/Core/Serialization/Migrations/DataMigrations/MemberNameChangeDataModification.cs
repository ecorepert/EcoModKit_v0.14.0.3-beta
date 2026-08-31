// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.MemberNameChangeDataModification
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

#nullable disable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>Rename member data modification.</summary>
public class MemberNameChangeDataModification : IDataModification
{
  public MemberNameChangeDataModification(
    MemberDataInput oldMember,
    MemberDataInput newMember,
    bool skipIfMissing = false);

  public void Initialize(MigrationManager manager);

  public void Apply(MigrationContext context);
}
