// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.Controls.ValueAndCollectionEditor`1
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System;
using System.ComponentModel;
using System.Drawing.Design;

#nullable disable
namespace Eco.Server.UI.Controls;

public class ValueAndCollectionEditor<T> : UITypeEditor
{
  public override object EditValue(
    ITypeDescriptorContext context,
    IServiceProvider provider,
    object value);

  public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context);
}
