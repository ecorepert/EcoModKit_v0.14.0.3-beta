// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Services.NotificationStyle
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Services;

[Serialized]
[Flags]
[TypeConverter(typeof (ValueTypeTypeConverter))]
public enum NotificationStyle
{
  Info = 1,
  InfoBox = 2,
  Warning = 4,
  Error = 8,
  Popup = 16, // 0x00000010
  Mail = 32, // 0x00000020
  MailOffline = 64, // 0x00000040
  Chat = 128, // 0x00000080
  Instant = 256, // 0x00000100
  EcoLog = 512, // 0x00000200
}
