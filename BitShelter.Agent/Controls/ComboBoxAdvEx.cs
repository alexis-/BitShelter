using Syncfusion.Windows.Forms.Tools;
using System;

namespace BitShelter.Agent.Controls
{
  public static class ComboBoxAdvEx
  {
    public static void FillWithEnum<T>(this ComboBoxAdv cb, T defaultValue)
    {
      var enumType = typeof(T);

      cb.DataSource = Enum.GetValues(enumType);
      cb.SelectedIndex = cb.Items.IndexOf(defaultValue);
    }
  }
}
