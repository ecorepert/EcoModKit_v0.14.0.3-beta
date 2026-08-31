// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MathParser.BinaryNode
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils.MathParser;

/// <summary> Represents math expressions as binary trees. </summary>
public abstract class BinaryNode
{
  public 
  #nullable disable
  BinaryNode Left;
  public BinaryNode Right;

  public (bool Success, LocString Error) TryResolve(
    out float result,
    Dictionary<string, float> nameToValue);

  public (bool Success, LocString Error) TryResolve(
    out float result,
    Dictionary<string, (float Value, LocString Description)> nameToDefinition = null);

  /// <summary> Resolve current node only. </summary>
  protected abstract (bool Success, LocString Error) TryResolveInternal(
    Stack<float> operands,
    Dictionary<string, float> nameToValue);
}
