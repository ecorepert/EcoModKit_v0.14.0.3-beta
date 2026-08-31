// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.StringBuilderExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;
using System.Text;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Static extension methods for the .NET <see cref="T:System.Text.StringBuilder" /> object.</summary>
public static class StringBuilderExtensions
{
  /// <summary>Appends <param name="str"> only if <paramref name="condition" /> is true.</param></summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static StringBuilder AppendLineIf(this StringBuilder sb, bool condition, string str);
}
