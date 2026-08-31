// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.Internal.Weaving.Extensions.LoggerExtensions
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Mono.Cecil.Cil;

#nullable enable
namespace Eco.ModKit.Internal.Weaving.Extensions;

/// <summary>Extension methods for Fody <see cref="T:ILogger" />.</summary>
public static class LoggerExtensions
{
  public static void LogWarningPoint(this ILogger logger, string message, SequencePoint? point);

  public static void LogErrorPoint(this ILogger logger, string message, SequencePoint? point);
}
