﻿#pragma checksum "..\..\..\..\Views\AjoutEntiteWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B01E2A8614E14BAB82A7999FAB3628EDF75F97B5"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_POO2.Views;
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


namespace Projet_POO2.Views {
    
    
    /// <summary>
    /// AjoutVinWindow
    /// </summary>
    public partial class AjoutVinWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NomVin;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TypeVin;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Alchool;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sulphates;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AcideCitrique;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VolatileAcidite;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Projet POO2;component/views/ajoutentitewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.13.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.NomVin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TypeVin = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Alchool = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Sulphates = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.AcideCitrique = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.VolatileAcidite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            
            #line 49 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Ajouter);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 50 "..\..\..\..\Views\AjoutEntiteWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

