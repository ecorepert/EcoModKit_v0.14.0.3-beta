// Decompiled with JetBrains decompiler
// Type: NSwagConfig
// Assembly: StrangeCloud.Service.Client.CSharp, Version=1.0.25.0, Culture=neutral, PublicKeyToken=null
// MVID: AAA52893-526A-4E25-B2C8-518262E68155
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\StrangeCloud.Service.Client.CSharp.xml

using Newtonsoft.Json;

#nullable disable
public static class NSwagConfig
{
  public static JsonSerializerSettings CreateCustomJsonSerializerSettings(
    JsonSerializerSettings settings)
  {
    settings.MissingMemberHandling = (MissingMemberHandling) 0;
    settings.NullValueHandling = (NullValueHandling) 0;
    settings.DefaultValueHandling = (DefaultValueHandling) 0;
    return settings;
  }
}
