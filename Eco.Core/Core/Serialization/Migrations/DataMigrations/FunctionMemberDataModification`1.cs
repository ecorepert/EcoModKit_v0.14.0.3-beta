// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.DataMigrations.FunctionMemberDataModification`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Serialization.Migrations.DataMigrations;

public class FunctionMemberDataModification<TOutput> : MemberDataModification<TOutput>
{
  public FunctionMemberDataModification(
    MemberDataInput member,
    IDataInput[] args,
    Func<Dictionary<IDataInput, ReaderDataInput>, ReaderDataInput[], TOutput> func);

  public override bool TryGenerateValue(
    Dictionary<IDataInput, ReaderDataInput> data,
    out TOutput value);
}
