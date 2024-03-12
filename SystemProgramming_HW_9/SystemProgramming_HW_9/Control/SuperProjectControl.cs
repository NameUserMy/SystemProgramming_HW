using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using SystemProgramming_HW_9.Model;
using static System.Net.Mime.MediaTypeNames;

namespace SystemProgramming_HW_9.Control
{
    internal class SuperProjectControl
    {

        private AssemblyLoadContext? area;
        private Assembly? plugin;
        private TypeInfo _myclass;
        private PluginInfoModel? _pluginInfo;
        public string? NameAssemblyContext { get; set; }
        public string? PathFromPlugin { get; set; }

        public void GetPluginInfo() {
             var pluginType = plugin.DefinedTypes;
           
            foreach (TypeInfo Myclass in pluginType)
            {
                Dispatcher.CurrentDispatcher.Invoke(()=>_pluginInfo.PluginInfoUpdate.Add($"Class : {Myclass}"));
                foreach (var method in Myclass.GetMethods())
                {
                    Dispatcher.CurrentDispatcher.Invoke(() => _pluginInfo.PluginInfoUpdate.Add($"Method : {method}"));
                }
            }
        }

        public void GetStaticMethodsSquareArea()
        {
            //RectangleArea
            _myclass = plugin.DefinedTypes.FirstOrDefault(e=>e.Name== "CalculateArea");
            object methods = plugin.CreateInstance(_myclass.FullName);
            var result= (double)_myclass.GetMethod("SquareArea").Invoke(null,new object[] {5});
            MessageBox.Show($"{result}");
        }

        public void GetMethodsRectangleArea()
        {
            
            _myclass = plugin.DefinedTypes.FirstOrDefault(e => e.Name == "CalculateArea");
            object methods = plugin.CreateInstance(_myclass.FullName);
            var result = (double)_myclass.GetMethod("RectangleArea").Invoke(methods, new object[] {8,4});
            MessageBox.Show($"{result}");
        }

        public SuperProjectControl (PluginInfoModel pluginInfo)
        {
            _pluginInfo = pluginInfo;
            PathFromPlugin = "H:\\KASHAG\\programming\\SystemProgramming\\HW\\SystemProgramming_HW_9\\SystemProgramming_HW_9\\Plugin\\AreaCalculation.dll";
            area = new AssemblyLoadContext(NameAssemblyContext, true);
            plugin = area.LoadFromAssemblyPath(PathFromPlugin);

        }

    }
}






    
