﻿#pragma checksum "C:\Users\Pedro Mateus\Source\Repos\ad-project-group-11\StreamingApp\StreaminApp1.UWP\Views\Categories\CategoryFormPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0B9D2CB525F6F34B8728ED2C6106C0DBBDC003B19329AE82FA759235E7AB8DC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StreamingApp.UWP.Views.Categories
{
    partial class CategoryFormPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBox_Text(global::Windows.UI.Xaml.Controls.TextBox obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class CategoryFormPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ICategoryFormPage_Bindings
        {
            private global::StreamingApp.UWP.Views.Categories.CategoryFormPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBox obj2;
            private global::Windows.UI.Xaml.Controls.Border obj3;
            private global::Windows.UI.Xaml.Controls.Border obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2TextDisabled = false;
            private static bool isobj3VisibilityDisabled = false;
            private static bool isobj7VisibilityDisabled = false;

            private CategoryFormPage_obj1_BindingsTracking bindingsTracking;

            public CategoryFormPage_obj1_Bindings()
            {
                this.bindingsTracking = new CategoryFormPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 50 && columnNumber == 12)
                {
                    isobj2TextDisabled = true;
                }
                else if (lineNumber == 54 && columnNumber == 17)
                {
                    isobj3VisibilityDisabled = true;
                }
                else if (lineNumber == 35 && columnNumber == 5)
                {
                    isobj7VisibilityDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Categories\CategoryFormPage.xaml line 49
                        this.obj2 = (global::Windows.UI.Xaml.Controls.TextBox)target;
                        this.bindingsTracking.RegisterTwoWayListener_2(this.obj2);
                        break;
                    case 3: // Views\Categories\CategoryFormPage.xaml line 53
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 7: // Views\Categories\CategoryFormPage.xaml line 34
                        this.obj7 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ICategoryFormPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::StreamingApp.UWP.Views.Categories.CategoryFormPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StreamingApp.UWP.Views.Categories.CategoryFormPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CategoryViewModel(obj.CategoryViewModel, phase);
                    }
                }
            }
            private void Update_CategoryViewModel(global::StreamingApp.UWP.ViewModels.CategoryViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_CategoryViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_CategoryViewModel_CategoryName(obj.CategoryName, phase);
                        this.Update_CategoryViewModel_Invalid(obj.Invalid, phase);
                    }
                }
            }
            private void Update_CategoryViewModel_CategoryName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Categories\CategoryFormPage.xaml line 49
                    if (!isobj2TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBox_Text(this.obj2, obj, null);
                    }
                }
            }
            private void Update_CategoryViewModel_Invalid(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                {
                    this.Update_CategoryViewModel_Invalid_Cast_Invalid_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_CategoryViewModel_Invalid_Cast_Invalid_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Categories\CategoryFormPage.xaml line 53
                    if (!isobj3VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                    }
                    // Views\Categories\CategoryFormPage.xaml line 34
                    if (!isobj7VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj7, obj);
                    }
                }
            }
            private void UpdateTwoWay_2_Text()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.CategoryViewModel != null)
                        {
                            this.dataRoot.CategoryViewModel.CategoryName = this.obj2.Text;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class CategoryFormPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<CategoryFormPage_obj1_Bindings> weakRefToBindingObj; 

                public CategoryFormPage_obj1_BindingsTracking(CategoryFormPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<CategoryFormPage_obj1_Bindings>(obj);
                }

                public CategoryFormPage_obj1_Bindings TryGetBindingObject()
                {
                    CategoryFormPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_CategoryViewModel(null);
                }

                public void PropertyChanged_CategoryViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    CategoryFormPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::StreamingApp.UWP.ViewModels.CategoryViewModel obj = sender as global::StreamingApp.UWP.ViewModels.CategoryViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_CategoryViewModel_CategoryName(obj.CategoryName, DATA_CHANGED);
                                bindings.Update_CategoryViewModel_Invalid(obj.Invalid, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "CategoryName":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CategoryViewModel_CategoryName(obj.CategoryName, DATA_CHANGED);
                                    }
                                    break;
                                }
                                case "Invalid":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_CategoryViewModel_Invalid(obj.Invalid, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::StreamingApp.UWP.ViewModels.CategoryViewModel cache_CategoryViewModel = null;
                public void UpdateChildListeners_CategoryViewModel(global::StreamingApp.UWP.ViewModels.CategoryViewModel obj)
                {
                    if (obj != cache_CategoryViewModel)
                    {
                        if (cache_CategoryViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_CategoryViewModel).PropertyChanged -= PropertyChanged_CategoryViewModel;
                            cache_CategoryViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_CategoryViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_CategoryViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_2(global::Windows.UI.Xaml.Controls.TextBox sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.TextBox.TextProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_2_Text();
                        }
                    });
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\Categories\CategoryFormPage.xaml line 49
                {
                    this.name = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // Views\Categories\CategoryFormPage.xaml line 23
                {
                    this.mainCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)(target);
                }
                break;
            case 5: // Views\Categories\CategoryFormPage.xaml line 28
                {
                    this.btnSave_Click = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnSave_Click).Click += this.BtnSave_Click;
                }
                break;
            case 6: // Views\Categories\CategoryFormPage.xaml line 42
                {
                    this.btnCancel_Click = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnCancel_Click).Click += this.BtnCancel_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // Views\Categories\CategoryFormPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    CategoryFormPage_obj1_Bindings bindings = new CategoryFormPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

