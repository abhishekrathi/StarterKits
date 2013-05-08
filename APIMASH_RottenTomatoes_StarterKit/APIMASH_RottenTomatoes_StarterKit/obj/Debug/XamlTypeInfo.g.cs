﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace APIMASH_RottenTomatoes_StarterKit
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            if(xamlType == null)
            {
                xamlType = CheckOtherMetadataProvidersForType(type);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType == null)
            {
                xamlType = CheckOtherMetadataProvidersForName(typeName);
            }
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_WebBrowser() { return new global::WinRTXamlToolkit.Controls.WebBrowser(); }

        private object Activate_2_PreviewControl() { return new global::APIMASH_RottenTomatoes_StarterKit.PreviewControl(); }

        private object Activate_3_LayoutAwarePage() { return new global::APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage(); }

        private object Activate_4_GroupedItemsPage() { return new global::APIMASH_RottenTomatoes_StarterKit.GroupedItemsPage(); }

        private object Activate_5_GroupDetailPage() { return new global::APIMASH_RottenTomatoes_StarterKit.GroupDetailPage(); }

        private object Activate_6_ReviewControl() { return new global::APIMASH_RottenTomatoes_StarterKit.ReviewControl(); }

        private object Activate_7_MovieReviewGroup() { return new global::APIMASH_RottenTomatoesLib.MovieReviewGroup(); }

        private object Activate_8_ItemDetailPage() { return new global::APIMASH_RottenTomatoes_StarterKit.ItemDetailPage(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Windows.UI.Xaml.Controls.Control":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Control));
                break;

            case "Boolean":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Boolean));
                break;

            case "Object":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Object));
                break;

            case "String":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.String));
                break;

            case "Windows.UI.Xaml.Controls.UserControl":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.UserControl));
                break;

            case "Windows.UI.Xaml.Controls.Page":
                xamlType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Page));
                break;

            case "WinRTXamlToolkit.Controls.WebBrowser":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::WinRTXamlToolkit.Controls.WebBrowser), GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
                userType.Activator = Activate_0_WebBrowser;
                userType.AddMemberName("AutoNavigate");
                AddToMapOfTypeToStandardName(typeof(global::System.Boolean),
                                                   "Boolean");
                userType.AddMemberName("Source");
                userType.AddMemberName("Title");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                xamlType = userType;
                break;

            case "System.Uri":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Uri), GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.PreviewControl":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.PreviewControl), GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_2_PreviewControl;
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage), GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_LayoutAwarePage;
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.GroupedItemsPage":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.GroupedItemsPage), GetXamlTypeByName("APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage"));
                userType.Activator = Activate_4_GroupedItemsPage;
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.GroupDetailPage":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.GroupDetailPage), GetXamlTypeByName("APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage"));
                userType.Activator = Activate_5_GroupDetailPage;
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.ReviewControl":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.ReviewControl), GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_6_ReviewControl;
                userType.AddMemberName("MovieReviews");
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoesLib.MovieReviewGroup":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoesLib.MovieReviewGroup), GetXamlTypeByName("Object"));
                userType.Activator = Activate_7_MovieReviewGroup;
                xamlType = userType;
                break;

            case "APIMASH_RottenTomatoes_StarterKit.ItemDetailPage":
                userType = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::APIMASH_RottenTomatoes_StarterKit.ItemDetailPage), GetXamlTypeByName("APIMASH_RottenTomatoes_StarterKit.Common.LayoutAwarePage"));
                userType.Activator = Activate_8_ItemDetailPage;
                xamlType = userType;
                break;

            }
            return xamlType;
        }

        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> _otherProviders;
        private global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider> OtherProviders
        {
            get
            {
                if(_otherProviders == null)
                {
                    _otherProviders = new global::System.Collections.Generic.List<global::Windows.UI.Xaml.Markup.IXamlMetadataProvider>();
                    global::Windows.UI.Xaml.Markup.IXamlMetadataProvider provider;
                    provider = new global::WinRTXamlToolkit.WinRTXamlToolkit_XamlTypeInfo.XamlMetaDataProvider() as global::Windows.UI.Xaml.Markup.IXamlMetadataProvider;
                    _otherProviders.Add(provider); 
                }
                return _otherProviders;
            }
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForName(string typeName)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(typeName);
                if(xamlType != null)
                {
                    return xamlType;
                }
            }
            return null;
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CheckOtherMetadataProvidersForType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            foreach(global::Windows.UI.Xaml.Markup.IXamlMetadataProvider xmp in OtherProviders)
            {
                xamlType = xmp.GetXamlType(type);
                if(xamlType != null)
                {
                    return xamlType;
                }
            }
            return null;
        }

        private object get_0_WebBrowser_AutoNavigate(object instance)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            return that.AutoNavigate;
        }
        private void set_0_WebBrowser_AutoNavigate(object instance, object Value)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            that.AutoNavigate = (global::System.Boolean)Value;
        }
        private object get_1_WebBrowser_Source(object instance)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            return that.Source;
        }
        private void set_1_WebBrowser_Source(object instance, object Value)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            that.Source = (global::System.Uri)Value;
        }
        private object get_2_WebBrowser_Title(object instance)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            return that.Title;
        }
        private void set_2_WebBrowser_Title(object instance, object Value)
        {
            var that = (global::WinRTXamlToolkit.Controls.WebBrowser)instance;
            that.Title = (global::System.String)Value;
        }
        private object get_3_ReviewControl_MovieReviews(object instance)
        {
            var that = (global::APIMASH_RottenTomatoes_StarterKit.ReviewControl)instance;
            return that.MovieReviews;
        }
        private void set_3_ReviewControl_MovieReviews(object instance, object Value)
        {
            var that = (global::APIMASH_RottenTomatoes_StarterKit.ReviewControl)instance;
            that.MovieReviews = (global::APIMASH_RottenTomatoesLib.MovieReviewGroup)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlMember xamlMember = null;
            global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "WinRTXamlToolkit.Controls.WebBrowser.AutoNavigate":
                userType = (global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WinRTXamlToolkit.Controls.WebBrowser");
                xamlMember = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlMember(this, "AutoNavigate", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_WebBrowser_AutoNavigate;
                xamlMember.Setter = set_0_WebBrowser_AutoNavigate;
                break;
            case "WinRTXamlToolkit.Controls.WebBrowser.Source":
                userType = (global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WinRTXamlToolkit.Controls.WebBrowser");
                xamlMember = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlMember(this, "Source", "System.Uri");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_WebBrowser_Source;
                xamlMember.Setter = set_1_WebBrowser_Source;
                break;
            case "WinRTXamlToolkit.Controls.WebBrowser.Title":
                userType = (global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("WinRTXamlToolkit.Controls.WebBrowser");
                xamlMember = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlMember(this, "Title", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_WebBrowser_Title;
                xamlMember.Setter = set_2_WebBrowser_Title;
                break;
            case "APIMASH_RottenTomatoes_StarterKit.ReviewControl.MovieReviews":
                userType = (global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlUserType)GetXamlTypeByName("APIMASH_RottenTomatoes_StarterKit.ReviewControl");
                xamlMember = new global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlMember(this, "MovieReviews", "APIMASH_RottenTomatoesLib.MovieReviewGroup");
                xamlMember.Getter = get_3_ReviewControl_MovieReviews;
                xamlMember.Setter = set_3_ReviewControl_MovieReviews;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlSystemBaseType
    {
        global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::APIMASH_RottenTomatoes_StarterKit.APIMASH_RottenTomatoes_StarterKit_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

