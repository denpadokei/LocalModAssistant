using System;
using System.Collections.Generic;
using System.Text;

namespace LocalModAssistant.Interfaces
{
    public interface IMainDomain
    {
        void InstallMods();
        void Load();
        void Save();
    }
}
