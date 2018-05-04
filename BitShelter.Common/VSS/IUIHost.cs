using BitShelter.Utils;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter.VSS
{
  // Based on https://github.com/alphaleonis/AlphaVSS
  public interface IUIHost
  {
    IDisposable GetIndent();

    void WriteLine();
    void WriteTable(LogEventLevel level, StringTable table, int columnSpacing = 3, bool addRowSpace = false);

    void PushIndent();
    void PopIndent();
    void WriteVerbose(string message, params object[] args);
    void WriteDebugHeader(string message, params object[] args);
    void WriteDebug(string message, params object[] args);
    void WriteWarning(string message, params object[] args);
    void WriteError(string message, params object[] args);
  }
}
