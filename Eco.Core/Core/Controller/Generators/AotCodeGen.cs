// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.Generators.AotCodeGen
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Text;

#nullable enable
namespace Eco.Core.Controller.Generators;

/// <summary>
/// <see cref="T:Eco.Core.Controller.Generators.AotCodeGen" /> generates dummy calls to generic methods to ensure these methods will be available after AOT via reflection.
/// AOT (ahead of time compilation) used on client side for IL2CPP build. AOT only compiles methods which may be discovered during compilation,
/// but if some method only called via reflection then in runtime it won't be available and an exception will be thrown instead.
/// To avoid the issue we need to hint AOT code gen with all possible generic method variants - for that we generate fake method calls
/// based on <see cref="F:Eco.Core.Controller.Generators.AotCodeGen.toBsonTypes" /> and <see cref="F:Eco.Core.Controller.Generators.AotCodeGen.fromBsonTypes" /> which may be used during BSON serialization/deserialization.
/// </summary>
public class AotCodeGen
{
  public AotCodeGen(ControllerMarshalerService marshalerService);

  /// <summary>Adds type which will be used in ToBson methods (during serialization).</summary>
  public void AddToBsonType(Type type);

  /// <summary>Adds type which will be used in FromBson methods (during deserialization).</summary>
  public void AddFromBsonType(Type type);

  /// <summary>Generates AotCodeGen content to <paramref name="template" />.</summary>
  public void Generate(StringBuilder template);
}
