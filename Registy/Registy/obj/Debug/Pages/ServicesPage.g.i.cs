﻿#pragma checksum "..\..\..\Pages\ServicesPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85AE28E6B00C64C8AF9F094E8A505575EE0A105C86841C8DEABE9FFC57001179"
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
    /// ServicesPage
    /// </summary>
    public partial class ServicesPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse StartElipse;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse TwoElipse;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ThreeElipse;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse FourElipse;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse FiveElipse;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\Pages\ServicesPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PreviousPageButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Registy;component/pages/servicespage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ServicesPage.xaml"
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
            this.StartElipse = ((System.Windows.Shapes.Ellipse)(target));
            
            #line 38 "..\..\..\Pages\ServicesPage.xaml"
            this.StartElipse.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.StartElipse_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TwoElipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 3:
            this.ThreeElipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 4:
            this.FourElipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 5:
            this.FiveElipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 6:
            
            #line 109 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 115 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 135 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 141 "..\..\..\Pages\ServicesPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 10:
            this.PreviousPageButton = ((System.Windows.Controls.Button)(target));
            
            #line 159 "..\..\..\Pages\ServicesPage.xaml"
            this.PreviousPageButton.Click += new System.Windows.RoutedEventHandler(this.PreviousPageButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

