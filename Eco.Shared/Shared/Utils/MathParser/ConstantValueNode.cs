// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MathParser.ConstantValueNode
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils.MathParser;

/// <summary> Binary node that repesents an operand with defined value. </summary>
public class ConstantValueNode : BinaryNode
{
  public float Value { get; set; }

  protected override (bool Success, LocString Error) TryResolveInternal(
    Stack<float> operands,
    Dictionary<string, float> nameToValue);
}
