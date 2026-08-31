// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Cecil.AssemblyConversionChecker
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil;
using System.Diagnostics;
using System.Reflection;

#nullable enable
namespace Eco.ModKit.Internal.Cecil;

/// <summary>Checks if a generated assembly from runtime Assembly matches an assembly loaded by Mono.Cecil from file.</summary>
internal static class AssemblyConversionChecker
{
  /// <summary>Main method for checker which loads <paramref name="assembly" /> from it's location and compares with <paramref name="generatedAssembly" />.</summary>
  [Conditional("CHECK_CONVERTED_ASSEMBLY")]
  public static void CheckGeneratedAssembly(AssemblyDefinition generatedAssembly, Assembly assembly);
}
