// Decompiled with JetBrains decompiler
// Type: Eco.Server.UI.Utils.ValueTypeTypeConverter`1
// Assembly: EcoServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F98E0BA7-72DE-473F-BCD0-D64424883057
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\EcoServer.dll

using System.Collections;
using System.ComponentModel;

#nullable disable
namespace Eco.Server.UI.Utils;

public class ValueTypeTypeConverter<T> : ExpandableObjectConverter where T : struct
{
  public override bool GetCreateInstanceSupported(ITypeDescriptorContext context);

  public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues);
}
