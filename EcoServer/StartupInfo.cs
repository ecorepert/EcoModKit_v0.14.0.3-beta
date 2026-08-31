// Decompiled with JetBrains decompiler
// Type: Eco.Server.StartupInfo
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.ModKit;

#nullable disable
namespace Eco.Server;

public class StartupInfo
{
  public bool GenerateDefault { get; }

  public string TestMode { get; }

  public bool NoNetwork { get; }

  public bool RunLocalization { get; }

  public ITypesProvider ModKitTypesProvider { get; set; }

  public static StartupInfo FromCommandLine();
}
