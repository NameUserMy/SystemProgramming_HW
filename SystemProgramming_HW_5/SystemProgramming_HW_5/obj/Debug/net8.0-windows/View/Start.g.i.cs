﻿#pragma checksum "..\..\..\..\View\Start.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FD268A3ACAC11DCB0A4BCF9058B959D173564F5A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using SystemProgramming_HW_5.View;


namespace SystemProgramming_HW_5.View {
    
    
    /// <summary>
    /// Start
    /// </summary>
    public partial class Start : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button firstBooton;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button secondBooton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Fourth;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button semafor;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newApp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\View\Start.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl CC;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SystemProgramming_HW_5;component/view/start.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Start.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.firstBooton = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\..\View\Start.xaml"
            this.firstBooton.Click += new System.Windows.RoutedEventHandler(this.firstBooton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.secondBooton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\..\View\Start.xaml"
            this.secondBooton.Click += new System.Windows.RoutedEventHandler(this.secondBooton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Fourth = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\..\View\Start.xaml"
            this.Fourth.Click += new System.Windows.RoutedEventHandler(this.Fourth_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.semafor = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\View\Start.xaml"
            this.semafor.Click += new System.Windows.RoutedEventHandler(this.semafor_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.newApp = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\View\Start.xaml"
            this.newApp.Click += new System.Windows.RoutedEventHandler(this.newApp_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CC = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
