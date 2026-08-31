// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PriorityAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

[AttributeUsage(AttributeTargets.Class)]
public class PriorityAttribute : Attribute
{
  public const int VeryHigh = -200;
  public const int High = -100;
  public const int Normal = 0;
  public const int Low = 100;
  public const int VeryLow = 200;

  public int Priority { get; protected set; }

  public PriorityAttribute(int priority);
}
