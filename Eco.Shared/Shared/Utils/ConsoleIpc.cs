// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ConsoleIpc
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Text.RegularExpressions;

#nullable disable
namespace Eco.Shared.Utils;

public static class ConsoleIpc
{
  public const string Prefix = "###";
  public static readonly Regex Regex;
  public const string ServerInitialisationFinished = "SERVER_INITIALIZATION_FINISHED";
  public const string ServerInitialisationFailed = "SERVER_INITIALIZATION_FAILED";
  public const string ServerAddressUnavailable = "SERVER_ADDRESS_UNAVAILABLE";
  public const string ServerShutdown = "SERVER_SHUTDOWN";

  public static string FormatLine(string message, string info = "");

  public static bool IsIpcMessage(string message);

  public static (string Message, string Info) ParseLine(string line);
}
