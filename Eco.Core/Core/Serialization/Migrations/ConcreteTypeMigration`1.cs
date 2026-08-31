// Decompiled with JetBrains decompiler
// Type: Eco.Core.Serialization.Migrations.ConcreteTypeMigration`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Serialization.Migrations;

/// <summary> Migration from base type to multiple concrete types by single (discriminator) field value. </summary>
public class ConcreteTypeMigration<TDiscriminator> : ConcreteTypeMigration
{
  /// <summary> Initializes a new instance of the <see cref="T:Eco.Core.Serialization.Migrations.ConcreteTypeMigration`1" /> class. </summary>
  /// <param name="baseTypeName">Base type name (from which concrete types will be expanded).</param>
  /// <param name="discriminatorName">Name of property or field in base object which will be used to determine concrete type name with typeMapper.</param>
  /// <param name="typeMapper">Function receives discriminator value and returns concrete type name evaluated from discriminator.</param>
  public ConcreteTypeMigration(
    string baseTypeName,
    string discriminatorName,
    Func<TDiscriminator, string> typeMapper);
}
