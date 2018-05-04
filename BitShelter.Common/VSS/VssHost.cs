using BitShelter.Utils;
using Serilog;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShelter.VSS
{
  public class VssHost : IUIHost
  {
    private int m_indent = 0;

    public VssHost()
    {
    }

    public void WriteDebugHeader(string message, params object[] args)
    {
      Log.Debug(message, args);
    }

    public void WriteDebug(string message, params object[] args)
    {
      Log.Debug(message, args);
    }

    public void WriteWarning(string message, params object[] args)
    {
      Log.Warning(message, args);
    }

    public void WriteError(string message, params object[] args)
    {
      Log.Error(message, args);
    }

    public void WriteVerbose(string message, params object[] args)
    {
      Log.Verbose(message, args);
    }

    public void WriteLine()
    {
      // Used to print a blank line
    }

    private void WriteForLevel(LogEventLevel level, string message, params object[] args)
    {
      switch (level)
      {
        case LogEventLevel.Fatal:
        case LogEventLevel.Error:
          WriteError(message, args);
          break;

        case LogEventLevel.Warning:
          WriteWarning(message, args);
          break;

        case LogEventLevel.Information:
        case LogEventLevel.Debug:
          WriteDebug(message, args);
          break;

        case LogEventLevel.Verbose:
        default:
          WriteVerbose(message, args);
          break;
      }
    }

    public void WriteTable(LogEventLevel level, StringTable table, int columnSpacing = 3, bool addVerticalSeparation = false)
    {
      if (table == null)
        throw new ArgumentNullException("table", "table is null.");

      StringBuilder builder = new StringBuilder();
      List<object> formatParams = new List<object>();

      for (int i = 0; i < table.Count; i++)
      {
        builder.AppendLine(String.Format("{{{0}}}{{{1}}}{{{2}}}{{{3}}}", 4 * i, 4 * i + 1, 4 * i + 2, 4 * i + 3));
        formatParams.Add(new String(' ', m_indent));
        formatParams.Add(table.Labels[i]);
        formatParams.Add(new String(' ', columnSpacing));
        formatParams.Add(table.Values[i]);
      }

      WriteForLevel(level, builder.ToString(), formatParams.ToArray());
    }

    public void PushIndent()
    {
      m_indent += 3;
    }

    public void PopIndent()
    {
      m_indent -= 3;
      if (m_indent < 0)
        m_indent = 0;
    }

    public IDisposable GetIndent()
    {
      return new Indenter(this);
    }

    private class Indenter : IDisposable
    {
      IUIHost m_host;
      public Indenter(IUIHost host)
      {
        m_host = host;
        m_host.PushIndent();
      }

      public void Dispose()
      {
        m_host.PopIndent();
      }
    }
  }
}