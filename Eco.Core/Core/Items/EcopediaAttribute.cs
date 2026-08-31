// Decompiled with JetBrains decompiler
// Type: Eco.Core.Items.EcopediaAttribute
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Items;

[AttributeUsage(AttributeTargets.Class)]
public class EcopediaAttribute : Attribute
{
  public string Cat;
  public string Page;
  public bool DisplayOnPage;
  public bool CreateAsSubPage;
  public string SubPageName;

  public EcopediaAttribute(
    string cat = null,
    string page = null,
    bool createAsSubPage = false,
    bool displayOnPage = true,
    string subPageName = null);
}
