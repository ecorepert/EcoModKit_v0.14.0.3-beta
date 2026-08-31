// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.Controls.SmartCollectionEditor`1
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System;
using System.ComponentModel;
using System.ComponentModel.Design;

#nullable disable
namespace Eco.Server.UI.Controls;

public class SmartCollectionEditor<T> : CollectionEditor
{
  public SmartCollectionEditor(Type type);

  public override object EditValue(
    ITypeDescriptorContext context,
    IServiceProvider provider,
    object value);

  protected override object SetItems(object editValue, object[] value);

  protected override bool CanSelectMultipleInstances();

  protected override string GetDisplayText(object value);
}
