using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemProgramming_Practical_final.Control.HookKey;
using SystemProgramming_Practical_final.Control.ProcessL;
using SystemProgramming_Practical_final.Model;

namespace SystemProgramming_Practical_final.Control.Settings
{
    internal class Settings
    {

        private KeyModel _keyModel;
        private ProcessModel _processModel;
        private Hook _hook;
        private ProcessListener _processListener;
        public KeyModel StartKey() {
            _keyModel = new KeyModel();
            _hook = new Hook(_keyModel);
            _hook.SetHook();
            return _keyModel;
        }
        public ProcessModel StartProcess()
        {
            _processModel = new ProcessModel();
            _processListener = new ProcessListener(_processModel);
            _processListener.Updateprocess();
            return _processModel;
        }
    }
}
