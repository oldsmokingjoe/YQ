﻿#pragma checksum "..\..\MainWindw.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1803985B1BB38B23A3FD64DB39D9BA92"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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


namespace window_demo {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tgbtn1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.ToggleButton tgbtn2;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button wireless;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bluetooth;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox list1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateUser;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAdministrator;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindw.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/window-demo;component/mainwindw.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindw.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tgbtn1 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 12 "..\..\MainWindw.xaml"
            this.tgbtn1.Checked += new System.Windows.RoutedEventHandler(this.bluetooth_connect);
            
            #line default
            #line hidden
            
            #line 13 "..\..\MainWindw.xaml"
            this.tgbtn1.Unchecked += new System.Windows.RoutedEventHandler(this.bluetooth_disconnect);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tgbtn2 = ((System.Windows.Controls.Primitives.ToggleButton)(target));
            
            #line 20 "..\..\MainWindw.xaml"
            this.tgbtn2.Checked += new System.Windows.RoutedEventHandler(this.wireless_connect);
            
            #line default
            #line hidden
            
            #line 21 "..\..\MainWindw.xaml"
            this.tgbtn2.Unchecked += new System.Windows.RoutedEventHandler(this.wireless_disconnect);
            
            #line default
            #line hidden
            return;
            case 3:
            this.wireless = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\MainWindw.xaml"
            this.wireless.Click += new System.Windows.RoutedEventHandler(this.wireless_click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.list2 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.bluetooth = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\MainWindw.xaml"
            this.bluetooth.Click += new System.Windows.RoutedEventHandler(this.bluetooth_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.list1 = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.CreateUser = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\MainWindw.xaml"
            this.CreateUser.Click += new System.Windows.RoutedEventHandler(this.createUserClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateAdministrator = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\MainWindw.xaml"
            this.CreateAdministrator.Click += new System.Windows.RoutedEventHandler(this.createAdminClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Logout = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\MainWindw.xaml"
            this.Logout.Click += new System.Windows.RoutedEventHandler(this.logoutClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

