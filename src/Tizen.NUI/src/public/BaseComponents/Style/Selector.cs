﻿/*
 * Copyright(c) 2019 Samsung Electronics Co., Ltd.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */
using System;
using System.ComponentModel;
using Tizen.NUI.Binding;
using Tizen.NUI.Components;

namespace Tizen.NUI.BaseComponents
{
    /// <summary>
    /// Selector class, which is related by Control State, it is base class for other Selector.
    /// </summary>
    /// <since_tizen> 6 </since_tizen>
    /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class Selector<T> : StateValueCollection<T>
    {
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        public static implicit operator Selector<T>(T value)
        {
            Selector<T> selector = new Selector<T>();
            selector.All = value;
            return selector;
        }

        /// Default Contructor
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector()
        {
        }

        /// Contructor with T
        [EditorBrowsable(EditorBrowsableState.Never)]
        public Selector(T value) : this()
        {
            All = value;
        }

        /// <summary>
        /// All State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T All
        {
            get;
            set;
        }
        /// <summary>
        /// Normal State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Normal
        {
            get => Find(x => x.State == ControlState.Normal).Value;
            set => Add(ControlState.Normal, value);
        }
        /// <summary>
        /// Pressed State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Pressed
        {
            get => Find(x => x.State == ControlState.Pressed).Value;
            set => Add(ControlState.Pressed, value);
        }
        /// <summary>
        /// Focused State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Focused
        {
            get => Find(x => x.State == ControlState.Focused).Value;
            set => Add(ControlState.Focused, value);
        }
        /// <summary>
        /// Selected State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Selected
        {
            get => Find(x => x.State == ControlState.Selected).Value;
            set => Add(ControlState.Selected, value);
        }
        /// <summary>
        /// Disabled State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Disabled
        {
            get => Find(x => x.State == ControlState.Disabled).Value;
            set => Add(ControlState.Disabled, value);
        }
        /// <summary>
        /// DisabledFocused State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T DisabledFocused
        {
            get => Find(x => x.State == ControlState.DisabledFocused).Value;
            set => Add(ControlState.DisabledFocused, value);
        }
        /// <summary>
        /// SelectedFocused State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        public T SelectedFocused
        {
            get => Find(x => x.State == ControlState.SelectedFocused).Value;
            set => Add(ControlState.SelectedFocused, value);
        }
        /// <summary>
        /// DisabledSelected State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T DisabledSelected
        {
            get => Find(x => x.State == ControlState.DisabledSelected).Value;
            set => Add(ControlState.DisabledSelected, value);
        }

        /// <summary>
        /// Other State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T Other
        {
            get => Find(x => x.State == ControlState.Other).Value;
            set => Add(ControlState.Other, value);
        }
        /// <summary>
        /// Get value by State.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public T GetValue(ControlState state)
        {
            if (All != null)
            {
                return All;
            }

            StateValuePair<T> value = Find(x => x.State == state);
            if (value.Value != null)
            {
                return value.Value;
            }

            if (state.IsCombined)
            {
                value = Find(x => state.Contains(x.State));
                if (value.Value != null)
                {
                    return value.Value;
                }
            }

            return Other;
        }

        /// <summary>
        /// Clone function.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public void Clone(Selector<T> selector)
        {
            All = selector.All;
            Normal = selector.Normal;
            Focused = selector.Focused;
            Pressed = selector.Pressed;
            Disabled = selector.Disabled;
            Selected = selector.Selected;
            DisabledSelected = selector.DisabledSelected;
            DisabledFocused = selector.DisabledFocused;
            SelectedFocused = selector.SelectedFocused;
            Other = selector.Other;
        }

        internal void Clone<U>(Selector<U> other) where U : T, Tizen.NUI.Internal.ICloneable
        {
            // TODO Apply constraint to the Selector (not to Clone method)

            All = (T)(other.All)?.Clone();
            Normal = (T)(other.Normal)?.Clone();
            Focused = (T)(other.Focused)?.Clone();
            Pressed = (T)(other.Pressed)?.Clone();
            Disabled = (T)(other.Disabled)?.Clone();
            Selected = (T)(other.Selected)?.Clone();
            DisabledSelected = (T)(other.DisabledSelected)?.Clone();
            DisabledFocused = (T)(other.DisabledFocused)?.Clone();
            SelectedFocused = (T)(other.SelectedFocused)?.Clone();
            Other = (T)(other.Other)?.Clone();
        }

        internal bool HasMultiValue()
        {
            return All == null;
        }
    }

    /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class TriggerableSelector<T> : Selector<T>
    {
        public TriggerableSelector(View view, BindableProperty bindableProperty)
        {
            targetView = view;
            targetBindableProperty = bindableProperty;
            view.ControlStateChangeEventInternal += OnViewControlState;
        }

        /// <summary>
        /// Clone function.
        /// </summary>
        /// <since_tizen> 6 </since_tizen>
        /// This will be public opened in tizen_6.0 after ACR done. Before ACR, need to be hidden as inhouse API.
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new void Clone(Selector<T> selector)
        {
            base.Clone(selector);

            if (null != targetView && null != GetValue(targetView.ControlState))
            {
                targetView.SetValue(targetBindableProperty, GetValue(targetView.ControlState));
            }
        }

        private void OnViewControlState(object obj, View.ControlStateChangedEventArgs controlStateChangedInfo)
        {
            View view = obj as View;
            if (null != view && null != GetValue(controlStateChangedInfo.CurrentState))
            {
                view.SetValue(targetBindableProperty, GetValue(controlStateChangedInfo.CurrentState));
            }
        }

        private View targetView;
        private BindableProperty targetBindableProperty;
    }

    /// <summary>
    /// A class that helps binding a non-selector property in View to selector property in ViewStyle.
    /// </summary>
    internal class ViewSelector<T>
    {
        protected Selector<T> selector;
        protected View view;
        protected EventHandler<View.ControlStateChangedEventArgs> controlStateChanged;

        internal ViewSelector(View view, EventHandler<View.ControlStateChangedEventArgs> controlStateChanged)
        {
            if (view == null || controlStateChanged == null)
            {
                throw new global::System.ArgumentNullException();
            }
            this.view = view;
            this.controlStateChanged = controlStateChanged;
            this.selector = null;
        }

        internal T GetValue()
        {
            return selector == null ? default(T) : selector.GetValue(view.ControlState);
        }

        internal void Set(object value)
        {
            bool hadMultiValue = HasMultiValue();
            var type = value?.GetType();

            if (type == typeof(T))
            {
                CopyValueToSelector((T)value);
            }
            else if (type == typeof(Selector<T>))
            {
                CopySelectorToSelector((Selector<T>)value);
            }
            else if (type == Nullable.GetUnderlyingType(typeof(T)))
            {
                CopyValueToSelector((T)value);
            }
            else
            {
                selector = null;
            }

            if (hadMultiValue != HasMultiValue())
            {
                if (hadMultiValue) view.ControlStateChangeEventInternal -= controlStateChanged;
                else view.ControlStateChangeEventInternal += controlStateChanged;
            }
        }

        protected virtual void CopyValueToSelector(T value)
        {
            selector = new Selector<T>();
            selector.All = value;
        }

        protected virtual void CopySelectorToSelector(Selector<T> value)
        {
            selector = new Selector<T>();
            selector.Clone(value);
        }

        internal void Clear()
        {
            if (HasMultiValue())
            {
                view.ControlStateChangeEventInternal -= controlStateChanged;
            }
            selector = null;
        }

        internal bool IsEmpty()
        {
            return selector == null;
        }

        protected bool HasMultiValue()
        {
            return (selector != null && selector.All == null);
        }
    }

    /// <summary>
    /// ViewSelector class for ICloneable type
    /// </summary>
    internal class CloneableViewSelector<T> : ViewSelector<T> where T : Tizen.NUI.Internal.ICloneable
    {
        internal CloneableViewSelector(View view, EventHandler<View.ControlStateChangedEventArgs> controlStateChanged) : base(view, controlStateChanged)
        {
        }

        protected override void CopyValueToSelector(T value)
        {
            selector = new Selector<T>();
            selector.All = (T)((T)value).Clone();
        }

        protected override void CopySelectorToSelector(Selector<T> value)
        {
            selector = new Selector<T>();
            selector.Clone<T>((Selector<T>)value);
        }
    }

    internal static class SelectorHelper
    {
        /// <summary>
        /// For the object type of T or Selector T, convert it to Selector T and return the cloned one.
        /// Otherwise, return null. <br/>
        /// </summary>
        static internal Selector<T> CopyCloneable<T>(object value) where T : class, Tizen.NUI.Internal.ICloneable
        {
            if (null != value)
            {
                var type = value.GetType();

                if (type == typeof(Selector<T>))
                {
                    var result = new Selector<T>();
                    result.Clone<T>((Selector<T>)value);
                    return result;
                }

                if (type == typeof(T))
                {
                    return new Selector<T>((T)((T)value).Clone());
                }
            }

            return null;
        }

        /// <summary>
        /// For the value type of T or Selector T, convert it to Selector T and return the cloned one.
        /// Otherwise, return null. <br/>
        /// </summary>
        static internal Selector<T> CopyValue<T>(object value)
        {
            if (null != value)
            {
                var type = value.GetType();

                if (type == typeof(Selector<T>))
                {
                    var result = new Selector<T>();
                    result.Clone((Selector<T>)value);
                    return result;
                }

                if (type == typeof(T))
                {
                    return new Selector<T>((T)value);
                }
            }

            return null;
        }
    }
}
