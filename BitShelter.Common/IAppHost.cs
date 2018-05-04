using BitShelter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitShelter
{
  public interface IAppHost
  {
    void OnPreInitialize();
    void OnPostInitialize();
    void Shutdown();
  }
}
