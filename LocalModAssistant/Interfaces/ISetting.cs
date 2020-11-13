using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace LocalModAssistant.Interfaces
{
    public interface ISetting : INotifyPropertyChanged
    {
        string InstallDirectory { get; set; }
        string ModDirectory { get; set; }
    }
}
