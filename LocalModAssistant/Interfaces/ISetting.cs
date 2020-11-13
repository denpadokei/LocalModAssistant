using System;
using System.Collections.Generic;
using System.Text;

namespace LocalModAssistant.Interfaces
{
    public interface ISetting
    {
        string InstallDirectory { get; set; }
        string ModDirectory { get; set; }
    }
}
