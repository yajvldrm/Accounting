﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("localhost")>  _
        Public Property _serverIP() As String
            Get
                Return CType(Me("_serverIP"),String)
            End Get
            Set
                Me("_serverIP") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("erp_file_setup_accounting_cct")>  _
        Public Property _serverDBFS() As String
            Get
                Return CType(Me("_serverDBFS"),String)
            End Get
            Set
                Me("_serverDBFS") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("erp_accounting_cct")>  _
        Public Property _serverDBMain() As String
            Get
                Return CType(Me("_serverDBMain"),String)
            End Get
            Set
                Me("_serverDBMain") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("root")>  _
        Public Property _serverUser() As String
            Get
                Return CType(Me("_serverUser"),String)
            End Get
            Set
                Me("_serverUser") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("snoitulos")>  _
        Public Property _serverPass() As String
            Get
                Return CType(Me("_serverPass"),String)
            End Get
            Set
                Me("_serverPass") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public ReadOnly Property groupVisibility() As Boolean
            Get
                Return CType(Me("groupVisibility"),Boolean)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property mysqlError() As Boolean
            Get
                Return CType(Me("mysqlError"),Boolean)
            End Get
            Set
                Me("mysqlError") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;password=~/Em0n121394:;persistsecurityinfo=True;por"& _ 
            "t=6033;database=erp_accounting_omp")>  _
        Public ReadOnly Property erp_accounting_alhiConnectionString() As String
            Get
                Return CType(Me("erp_accounting_alhiConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;password=~/Em0n121394:;port=6033;database=erp_file_"& _ 
            "setup_accounting_omp")>  _
        Public ReadOnly Property erp_file_setup_accounting_alhiConnectionString() As String
            Get
                Return CType(Me("erp_file_setup_accounting_alhiConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3306")>  _
        Public Property _serverPort() As String
            Get
                Return CType(Me("_serverPort"),String)
            End Get
            Set
                Me("_serverPort") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;password=~/Em0n121394:;persistsecurityinfo=True;por"& _ 
            "t=6033;database=erp_file_setup_accounting_omp")>  _
        Public ReadOnly Property erp_file_setup_accounting_alhiConnectionString1() As String
            Get
                Return CType(Me("erp_file_setup_accounting_alhiConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=localhost;user id=root;persistsecurityinfo=True;port=6033;database=erp_fil"& _ 
            "e_setup_accounting_omp;password=~/Em0n121394:")>  _
        Public ReadOnly Property erp_file_setup_accounting_alhiConnectionString2() As String
            Get
                Return CType(Me("erp_file_setup_accounting_alhiConnectionString2"),String)
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("server=192.168.10.59;user id=root;password=toor;persistsecurityinfo=True;database"& _ 
            "=erp_fs;allowzerodatetime=True;convertzerodatetime=True")>  _
        Public ReadOnly Property erp_fsConnectionString() As String
            Get
                Return CType(Me("erp_fsConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _enableUnitNo() As Boolean
            Get
                Return CType(Me("_enableUnitNo"),Boolean)
            End Get
            Set
                Me("_enableUnitNo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property _enableProjectUnit() As Boolean
            Get
                Return CType(Me("_enableProjectUnit"),Boolean)
            End Get
            Set
                Me("_enableProjectUnit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property _enableBookUnit() As Boolean
            Get
                Return CType(Me("_enableBookUnit"),Boolean)
            End Get
            Set
                Me("_enableBookUnit") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("%20%20127.0.0.1%20accounting$%20xls%20")>  _
        Public Property XLSPath() As String
            Get
                Return CType(Me("XLSPath"),String)
            End Get
            Set
                Me("XLSPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property _withPM() As Boolean
            Get
                Return CType(Me("_withPM"),Boolean)
            End Get
            Set
                Me("_withPM") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.accounting.My.MySettings
            Get
                Return Global.accounting.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace