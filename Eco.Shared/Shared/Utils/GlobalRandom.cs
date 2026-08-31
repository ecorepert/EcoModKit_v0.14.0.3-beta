// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.GlobalRandom
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <remarks>
/// Exposed implementation of Global Random from MoreLinq to be publicly available.
/// <see cref="T:System.Random" /> is not thread-safe so the following
/// implementation uses thread-local <see cref="T:System.Random" />
/// instances to create the illusion of a global
/// <see cref="T:System.Random" /> implementation. For some background,
/// see <a href="https://blogs.msdn.microsoft.com/pfxteam/2009/02/19/getting-random-numbers-in-a-thread-safe-way/">Getting
/// random numbers in a thread-safe way</a>
/// </remarks>
public sealed class GlobalRandom : Random
{
  public static readonly Random Instance;

  public override int Next();

  public override int Next(int minValue, int maxValue);

  public override int Next(int maxValue);

  public override double NextDouble();

  public override void NextBytes(byte[] buffer);

  protected override double Sample();
}
