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

Imports System

Namespace My.Resources

    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("TJCPowerPoint.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = Value
            End Set
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property bible() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("bible", resourceCulture)
                Return CType(obj, Byte())
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Dropper() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Dropper", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Font() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Font", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property ServiceWidescreen() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("ServiceWidescreen", resourceCulture)
                Return CType(obj, Byte())
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Service4to3() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Service4to3", resourceCulture)
                Return CType(obj, Byte())
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Settings() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Settings", resourceCulture)
                Return CType(obj, Byte())
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property XML() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("XML", resourceCulture)
                Return CType(obj, Byte())
            End Get
        End Property
    End Module
End Namespace
