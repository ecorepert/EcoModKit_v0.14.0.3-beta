// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.MigrationType
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Contains information about new type added during migration. Without this info it won't be possible to encode the type. </summary>
public class MigrationType
{
  public double SinceVersion { get; }

  public Type Type { get; }

  public string TargetSchemaType { get; }

  public MigrationType(double sinceVersion, Type type, string targetSchemaType);

  protected bool Equals(MigrationType other);

  public override bool Equals(object obj);

  public override int GetHashCode();
}
