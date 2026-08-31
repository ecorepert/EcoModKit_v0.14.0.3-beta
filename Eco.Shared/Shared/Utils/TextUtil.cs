// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.TextUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using System;

#nullable disable
namespace Eco.Shared.Utils;

public static class TextUtil
{
  /// <summary>Joins an arbitrary number of localized strings together with the joiner, if not null.</summary>
  public static LocString JoinLocStr(string joiner, params LocString?[] list);

  public static event Action<INetClient, LocString> WarnOutsideLength;

  /// <summary> Method to check the size of the strings that pass through the RPC, if they have a Range attribute we limit the size to this, if not then we check that MaxTextSize is not reached </summary>
  public static bool CheckRPCLength(INetClient client, RPCInvocation invocation);

  /// <summary>Check that the incoming string is under the allowed limits of text sizes, in case it is not return False and and return a message with the description of why it failed.</summary>
  public static bool CheckLength(
    EcoTextLimit range,
    string s,
    out LocString errorMessage,
    bool ignoreTags = false);

  /// <summary>Replaces numbers and percents with highlighted versions for eco credits.</summary>
  public static string HighlightEcoCreditPrices(string text);

  /// <summary>Replaces numbers, percents, and numbers followed by 'E' with highlighted versions.</summary>
  public static string HighlightNumbers(
    string text,
    Func<Decimal, string> processNumbers,
    Func<Decimal, string> processPercents,
    Func<Decimal, string> processNumbersWithE);
}
