// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.WebServer
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System.Net;

#nullable enable
namespace Eco.WebServer;

public class WebServer
{
  public bool Init(
  #nullable disable
  IPAddress address, int port);

  public void Start();

  public void Close();

  public static class NetAclChecker
  {
    public static bool AddAddress(string address);

    public static bool AddAddress(string address, string domain, string user);
  }
}
