// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ProfanityFilter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

public class ProfanityFilter : AutoSingleton<ProfanityFilter>
{
  public Func<string, (bool Censored, string CensoredTxt)>? AlternativeCensor;

  public static event Action<INetClient, string, string>? RPCProfanity;

  public bool Enabled { get; }

  /// <summary>Initializes the <see cref="T:Eco.Shared.Utils.ProfanityFilter" /> singleton with a predefined list of blacklisted "profane" words.</summary>
  /// <param name="blackListWords"><see cref="T:System.Collections.Generic.IEnumerable`1" /> containing all blacklisted/censored "profane" words.</param>
  public ProfanityFilter(IEnumerable<string> blackListWords);

  /// <summary>Initializes the <see cref="T:Eco.Shared.Utils.ProfanityFilter" /> singleton with the blacklisted words defined by the <see cref="T:Eco.Shared.Utils.ProfaneWords" /> singleton.</summary>
  public ProfanityFilter();

  /// <summary>Validates and returns if the text contains profane content.</summary>
  /// <param name="text"><see cref="T:System.String" /> to check for profanity.</param>
  /// <returns>True if profanity was detected. Otherwise returns false.</returns>
  public bool ValidateTextContainsProfanity(string text, bool strict = false);

  /// <summary>Invokes <paramref name="invocation" /> with profanity filter.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static object? Invoke(INetClient? client, in RPCInvocation invocation);

  public static bool FilterRPC(
    INetClient? client,
    RPCMethod method,
    object target,
    Span<object> args);

  public static bool IsClean(string text);

  /// <summary>Cleans a text <see cref="T:System.String" /> instance of any profanity found in it.</summary>
  /// <param name="text"><see cref="T:System.String" /> to censor profanity from if detected.</param>
  /// <returns>Censored <see cref="T:System.String" /> if profanity was detected in the original text <see cref="T:System.String" /></returns>
  public static string Clean(string text);
}
