﻿#pragma checksum "..\..\..\..\Paginas\Batalla.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FDED3C6D39C49E0098688FE34E95B8247E98CFC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Firts_Fantasy;
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


namespace Firts_Fantasy {
    
    
    /// <summary>
    /// Batalla
    /// </summary>
    public partial class Batalla : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgArmadura;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgArma;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgObj1;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgObj2;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgObj3;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recVidArma;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recVidArmadura;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recVidBoss;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Paginas\Batalla.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle recVidBoss_Copy;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Firts Fantasy;component/paginas/batalla.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Paginas\Batalla.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.imgArmadura = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.imgArma = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.imgObj1 = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.imgObj2 = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.imgObj3 = ((System.Windows.Controls.Image)(target));
            return;
            case 6:
            this.recVidArma = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 7:
            this.recVidArmadura = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            this.recVidBoss = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 9:
            
            #line 30 "..\..\..\..\Paginas\Batalla.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.recVidBoss_Copy = ((System.Windows.Shapes.Rectangle)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
