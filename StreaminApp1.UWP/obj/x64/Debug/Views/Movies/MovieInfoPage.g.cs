﻿#pragma checksum "C:\Users\Pedro Mateus\Source\Repos\ad-project-group-11\StreamingApp\StreaminApp1.UWP\Views\Movies\MovieInfoPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD3E0179181E563E5DA0D4E37E8631592EFC86466902BB8D5072933409CF2293"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StreaminApp1.UWP.Views.Movies
{
    partial class MovieInfoPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(global::Windows.UI.Xaml.Media.ImageBrush obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.ImageSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj, global::System.Nullable<global::System.Boolean> value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Boolean) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Boolean), targetNullValue);
                }
                obj.IsChecked = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MovieInfoPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMovieInfoPage_Bindings
        {
            private global::StreaminApp1.UWP.Views.Movies.MovieInfoPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Media.ImageBrush obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.Primitives.ToggleButton obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;
            private global::Windows.UI.Xaml.Controls.TextBlock obj9;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ImageSourceDisabled = false;
            private static bool isobj3TextDisabled = false;
            private static bool isobj4TextDisabled = false;
            private static bool isobj5IsCheckedDisabled = false;
            private static bool isobj7TextDisabled = false;
            private static bool isobj8TextDisabled = false;
            private static bool isobj9TextDisabled = false;

            private MovieInfoPage_obj1_BindingsTracking bindingsTracking;

            public MovieInfoPage_obj1_Bindings()
            {
                this.bindingsTracking = new MovieInfoPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 14 && columnNumber == 45)
                {
                    isobj2ImageSourceDisabled = true;
                }
                else if (lineNumber == 28 && columnNumber == 37)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 91 && columnNumber == 38)
                {
                    isobj4TextDisabled = true;
                }
                else if (lineNumber == 69 && columnNumber == 116)
                {
                    isobj5IsCheckedDisabled = true;
                }
                else if (lineNumber == 52 && columnNumber == 44)
                {
                    isobj7TextDisabled = true;
                }
                else if (lineNumber == 39 && columnNumber == 44)
                {
                    isobj8TextDisabled = true;
                }
                else if (lineNumber == 40 && columnNumber == 44)
                {
                    isobj9TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // Views\Movies\MovieInfoPage.xaml line 14
                        this.obj2 = (global::Windows.UI.Xaml.Media.ImageBrush)target;
                        break;
                    case 3: // Views\Movies\MovieInfoPage.xaml line 28
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 4: // Views\Movies\MovieInfoPage.xaml line 91
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // Views\Movies\MovieInfoPage.xaml line 69
                        this.obj5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)target;
                        this.bindingsTracking.RegisterTwoWayListener_5(this.obj5);
                        break;
                    case 7: // Views\Movies\MovieInfoPage.xaml line 52
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 8: // Views\Movies\MovieInfoPage.xaml line 39
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 9: // Views\Movies\MovieInfoPage.xaml line 40
                        this.obj9 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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

            // IMovieInfoPage_Bindings

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
                    this.dataRoot = (global::StreaminApp1.UWP.Views.Movies.MovieInfoPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::StreaminApp1.UWP.Views.Movies.MovieInfoPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MovieViewModel(obj.MovieViewModel, phase);
                    }
                }
            }
            private void Update_MovieViewModel(global::StreamingApp.UWP.ViewModels.MovieViewModel obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_MovieViewModel(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MovieViewModel_MoviePosterImage(obj.MoviePosterImage, phase);
                        this.Update_MovieViewModel_MovieName(obj.MovieName, phase);
                        this.Update_MovieViewModel_MovieDescription(obj.MovieDescription, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_MovieViewModel_IsFavourite(obj.IsFavourite, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_MovieViewModel_MovieRating(obj.MovieRating, phase);
                        this.Update_MovieViewModel_MovieDuration(obj.MovieDuration, phase);
                        this.Update_MovieViewModel_MovieReleased(obj.MovieReleased, phase);
                    }
                }
            }
            private void Update_MovieViewModel_MoviePosterImage(global::Windows.UI.Xaml.Media.Imaging.BitmapImage obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 14
                    if (!isobj2ImageSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Media_ImageBrush_ImageSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_MovieViewModel_MovieName(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 28
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj, null);
                    }
                }
            }
            private void Update_MovieViewModel_MovieDescription(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 91
                    if (!isobj4TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                    }
                }
            }
            private void Update_MovieViewModel_IsFavourite(global::System.Boolean obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 69
                    if (!isobj5IsCheckedDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_ToggleButton_IsChecked(this.obj5, obj, null);
                    }
                }
            }
            private void Update_MovieViewModel_MovieRating(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 52
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj.ToString(), null);
                    }
                }
            }
            private void Update_MovieViewModel_MovieDuration(global::System.TimeSpan obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 39
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj.ToString(), null);
                    }
                }
            }
            private void Update_MovieViewModel_MovieReleased(global::System.DateTimeOffset obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Views\Movies\MovieInfoPage.xaml line 40
                    if (!isobj9TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj9, obj.ToString(), null);
                    }
                }
            }
            private void UpdateTwoWay_5_IsChecked()
            {
                if (this.initialized)
                {
                    if (this.dataRoot != null)
                    {
                        if (this.dataRoot.MovieViewModel != null)
                        {
                            this.dataRoot.MovieViewModel.IsFavourite = (global::System.Boolean)this.obj5.IsChecked;
                        }
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MovieInfoPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MovieInfoPage_obj1_Bindings> weakRefToBindingObj; 

                public MovieInfoPage_obj1_BindingsTracking(MovieInfoPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MovieInfoPage_obj1_Bindings>(obj);
                }

                public MovieInfoPage_obj1_Bindings TryGetBindingObject()
                {
                    MovieInfoPage_obj1_Bindings bindingObject = null;
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
                    UpdateChildListeners_MovieViewModel(null);
                }

                public void PropertyChanged_MovieViewModel(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MovieInfoPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::StreamingApp.UWP.ViewModels.MovieViewModel obj = sender as global::StreamingApp.UWP.ViewModels.MovieViewModel;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_MovieViewModel_IsFavourite(obj.IsFavourite, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "IsFavourite":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_MovieViewModel_IsFavourite(obj.IsFavourite, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                private global::StreamingApp.UWP.ViewModels.MovieViewModel cache_MovieViewModel = null;
                public void UpdateChildListeners_MovieViewModel(global::StreamingApp.UWP.ViewModels.MovieViewModel obj)
                {
                    if (obj != cache_MovieViewModel)
                    {
                        if (cache_MovieViewModel != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_MovieViewModel).PropertyChanged -= PropertyChanged_MovieViewModel;
                            cache_MovieViewModel = null;
                        }
                        if (obj != null)
                        {
                            cache_MovieViewModel = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_MovieViewModel;
                        }
                    }
                }
                public void RegisterTwoWayListener_5(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton sourceObject)
                {
                    sourceObject.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Primitives.ToggleButton.IsCheckedProperty, (sender, prop) =>
                    {
                        var bindingObj = this.TryGetBindingObject();
                        if (bindingObj != null)
                        {
                            bindingObj.UpdateTwoWay_5_IsChecked();
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
            case 5: // Views\Movies\MovieInfoPage.xaml line 69
                {
                    global::Windows.UI.Xaml.Controls.Primitives.ToggleButton element5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)element5).Click += this.ToggleButton_Click;
                }
                break;
            case 6: // Views\Movies\MovieInfoPage.xaml line 77
                {
                    this.ToggleButtonText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            case 1: // Views\Movies\MovieInfoPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MovieInfoPage_obj1_Bindings bindings = new MovieInfoPage_obj1_Bindings();
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

