﻿#pragma checksum "..\..\..\..\Views\InProgramWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC6DC46261E69228BFC4B4271033B68ED1F2688E"
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
    /// InProgramWindow
    /// </summary>
    public partial class InProgramWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageAccueil;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Alchool;
        
        #line default
        #line hidden
        
        
        #line 186 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Sulphates;
        
        #line default
        #line hidden
        
        
        #line 189 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AcideCitrique;
        
        #line default
        #line hidden
        
        
        #line 192 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VolatileAcidite;
        
        #line default
        #line hidden
        
        
        #line 221 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNom;
        
        #line default
        #line hidden
        
        
        #line 224 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrenom;
        
        #line default
        #line hidden
        
        
        #line 227 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DateDeNaissance;
        
        #line default
        #line hidden
        
        
        #line 234 "..\..\..\..\Views\InProgramWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMotDePasse;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet POO2;component/views/inprogramwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\InProgramWindow.xaml"
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
            
            #line 14 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Ouvrir);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 16 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Quitter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MessageAccueil = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 87 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GererVignoble);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 88 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GererTerrain);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 89 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.GererVin);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Alchool = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Sulphates = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AcideCitrique = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.VolatileAcidite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 196 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Predire);
            
            #line default
            #line hidden
            return;
            case 12:
            this.txtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.txtPrenom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.DateDeNaissance = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 15:
            this.txtMotDePasse = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 16:
            
            #line 235 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ModifierMotDePasse);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 245 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Annuler);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 246 "..\..\..\..\Views\InProgramWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Confirmer);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

