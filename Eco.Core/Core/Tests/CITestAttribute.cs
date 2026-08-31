// Decompiled with JetBrains decompiler
// Type: Eco.Core.Tests.CITestAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Tests;

[AttributeUsage(AttributeTargets.Method)]
public class CITestAttribute : Attribute
{
  public bool NeedsClient { get; }

  public CITestAttribute(bool clientDependent = false);
}
