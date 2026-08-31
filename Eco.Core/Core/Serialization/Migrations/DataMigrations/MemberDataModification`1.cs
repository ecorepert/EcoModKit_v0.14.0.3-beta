// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.MemberDataModification`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Serialization.Serializers;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

/// <summary>Base class for data member modifications with known output value type. Used in <see cref="T:Eco.Core.Serialization.Migrations.DataMigration" />.</summary>
public abstract class MemberDataModification<TOutput> : MemberDataModification
{
  protected ISerializer outputSerializer;

  protected MemberDataModification(MemberDataInput member);

  public override void Initialize(MigrationManager manager);

  public sealed override ReaderDataInput? GenerateOutput(MigrationContext context);

  /// <summary>Tries to generate value for data member. Returns <c>false</c> if value can't be generated and member should be removed.</summary>
  public abstract bool TryGenerateValue(
    Dictionary<IDataInput, ReaderDataInput> data,
    out TOutput value);
}
