﻿#pragma checksum "..\..\..\Pages\AuthorizationPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0B36094645F5F3DC59EE0200A88C8172C9CDA63B8C0693BE3D0B613A172C64B0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Registy.Pages;
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


namespace Registy.Pages {
    
    
    /// <summary>
    /// AuthorizationPage
    /// </summary>
    public partial class AuthorizationPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToBeginPage;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authLoginTextBox;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authPasswordTextBox;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AuthorizationButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Pages\AuthorizationPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChangePasswordButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Registy;component/pages/authorizationpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\AuthorizationPage.xaml"
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
            
            #line 10 "..\..\..\Pages\AuthorizationPage.xaml"
            ((Registy.Pages.AuthorizationPage)(target)).PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Page_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.BackToBeginPage = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Pages\AuthorizationPage.xaml"
            this.BackToBeginPage.Click += new System.Windows.RoutedEventHandler(this.BackToBeginPage_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.authLoginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.authPasswordTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.AuthorizationButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Pages\AuthorizationPage.xaml"
            this.AuthorizationButton.Click += new System.Windows.RoutedEventHandler(this.AuthorizationButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ChangePasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 70 "..\..\..\Pages\AuthorizationPage.xaml"
            this.ChangePasswordButton.Click += new System.Windows.RoutedEventHandler(this.ChangePasswordButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

