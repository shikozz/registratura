﻿#pragma checksum "..\..\..\Pages\FinishedAppointmentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83B2EC67ECDB1E8D63166DB67B2982F197610077B06D14E3610018DE13E5ED84"
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
    /// FinishedAppointmentPage
    /// </summary>
    public partial class FinishedAppointmentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse StartElipse;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse TwoElipse;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse ThreeElipse;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse FourElipse;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse FiveElipse;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock HeaderTextBlock;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InformationTextBlock;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\Pages\FinishedAppointmentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitButton;
        
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
            System.Uri resourceLocater = new System.Uri("/Registy;component/pages/finishedappointmentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\FinishedAppointmentPage.xaml"
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
            this.HeaderTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.InformationTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ExitButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Pages\FinishedAppointmentPage.xaml"
            this.ExitButton.Click += new System.Windows.RoutedEventHandler(this.OnCloseButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
