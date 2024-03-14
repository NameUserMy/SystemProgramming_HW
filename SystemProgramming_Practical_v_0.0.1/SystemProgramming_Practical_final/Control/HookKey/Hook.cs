using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using SystemProgramming_Practical_final.Model;

namespace SystemProgramming_Practical_final.Control.HookKey
{



    internal class Hook
    {

        const int WH_KEYBOARD_LL = 13; // Номер глобального LowLevel-хука на клавиатуру
        const int WM_KEYDOWN = 0x100; // Сообщения нажатия клавиши

        private static KeyModel _keyModel;
        
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private LowLevelKeyboardProc _proc = hookProc;
        private static IntPtr hhook = IntPtr.Zero;
        uint _processid;
        #region Импорт необходимых функций из Win Appi

        //для установки хука 
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook/*(Устанавливает процедуру перехватчика)*/, 
            LowLevelKeyboardProc callback/*(Refernce на процедуру перехватчика. delegate or event)*/,
            IntPtr hInstance, uint threadId);

        //Для отключения хука
        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);
        //обработка хука возрашает состояние хука
        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);
        //для загрузкм необходимого модуля
        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        //для получения hendle активного окна 
        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        //Для получения заголовка активного окна
        [DllImport("user32.dll")]
        static extern IntPtr GetWindowTextA(IntPtr hWnd, StringBuilder lspstring,int nMaxCount);

        //[DllImport("kernel32.dll")]
        //static extern bool CreateDirectory(string lpTemplateDirectory,string lpNewDirectory);
        #endregion
        public void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance,0);
        }
        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }
        public static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                char tt = Convert.ToChar(vkCode);
                Application.Current.Dispatcher.Invoke(()=> _keyModel.KeyInfo.Add($"{tt}"));
                return (IntPtr)1;

            }
            else
                return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        public Hook(KeyModel keyModel)
        {
            _keyModel = keyModel;
            
            //StringBuilder testNamewindow=new StringBuilder(256);
            //MessageBox.Show($"{GetForegroundWindow()}");
            ////MessageBox.Show($"ddd {t}");
            //GetWindowTextA(GetForegroundWindow(), testNamewindow,testNamewindow.Capacity);
            //MessageBox.Show($"{testNamewindow}");
            
        }
    }
}
