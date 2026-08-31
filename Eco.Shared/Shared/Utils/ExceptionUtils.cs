// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ExceptionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.Shared.Utils;

public static class ExceptionUtils
{
  /// <summary>Recursively tries to find exception of type <typeparamref name="T" /> for the <paramref name="exception" />. It may be <paramref name="exception" /> itself or one of it's inner exceptions.</summary>
  public static bool TryFindExceptionOfType<T>(this Exception exception, [NotNullWhen(true)] out T? targetException) where T : Exception;

  /// <summary>Recursively tries to find exception of type <typeparamref name="T" /> in <paramref name="exception" /> inner exceptions.</summary>
  public static bool TryFindExceptionOfType<T>(
    this AggregateException exception,
    [NotNullWhen(true)] out T? targetException)
    where T : Exception;
}
