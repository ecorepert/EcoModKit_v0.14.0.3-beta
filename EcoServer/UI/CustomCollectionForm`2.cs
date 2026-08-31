// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.CustomCollectionForm`2
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using Eco.Core.Utils;
using System.Windows.Forms;

#nullable disable
namespace Eco.Server.UI;

public class CustomCollectionForm<TClass, TSubClass> : Form
  where TClass : class
  where TSubClass : class, TClass
{
  public object Programmed;

  public CustomCollectionForm(ReferenceList<TClass, TSubClass> value);

  public CustomCollectionForm(ReferenceItem<TClass, TSubClass> value);

  protected override void Dispose(bool disposing);
}
