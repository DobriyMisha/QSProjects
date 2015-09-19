﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Gamma.Binding.Core.Helpers;

namespace Gamma.Binding.Core
{
	public class BindingControler<TWidget> : IBindingControlerInternal, IBindingControler
	{
		TWidget widget;
		string[] backwardProperties = new string[0];

		public string[] BackwardProperties {
			get {
				return backwardProperties;
			}
			private set {
				backwardProperties = value;
			}
		}

		List<IBindingSourceInternal> Sources = new List<IBindingSourceInternal> ();

		public BindingControler (TWidget targetWidget, string[] backwards) : this(targetWidget)
		{
			BackwardProperties = backwards;
		}

		public BindingControler (TWidget targetWidget, Expression<Func<TWidget, object>>[] backwardsExp) : this(targetWidget)
		{
			BackwardProperties = backwardsExp.Select (exp => 
				String.Join (".", PropertyChainFromExp.Get (exp).Select (p => p.Name)))
				.ToArray ();
		}

		public BindingControler (TWidget targetWidget)
		{
			widget = targetWidget;
		}

		#region internal

		void IBindingControlerInternal.TargetSetValue(PropertyInfo[] propertyChain, object value)
		{
			this.TargetSetValue(propertyChain, value);
		}

		internal void TargetSetValue(PropertyInfo[] propertyChain, object value)
		{
			object target = widget;
			PropertyInfo lastProp = null;
			foreach(PropertyInfo curProp in propertyChain)
			{
				if (lastProp != null)
					target = lastProp.GetValue (target, null);
				lastProp = curProp;
			}
			lastProp.SetValue (target, value, null);
		}

		internal object TargetGetValue(PropertyInfo[] propertyChain)
		{
			object target = widget;
			PropertyInfo lastProp = null;
			foreach(PropertyInfo curProp in propertyChain)
			{
				if (lastProp != null)
					target = lastProp.GetValue (target, null);
				lastProp = curProp;
			}
			return lastProp.GetValue (target, null);
		}

		internal bool SourceSetValue(string property, object value)
		{
			bool anyseted = false;
			if (!BackwardProperties.Contains (property))
				throw new InvalidOperationException (String.Format ("Свойство {0}, не задано в качестве возвращающего значения в источник.", property));
			foreach(var source in Sources)
			{
				foreach(var bridge in source.GetBackwardBridges (property))
				{
					if (source.SetValueToSource (bridge, value))
						anyseted = true;
				}
			}
			return anyseted;
		}

		#endregion

		public void FireChange(params Expression<Func<TWidget, object>>[] targetProperties)
		{
			foreach (var Property in targetProperties) {
				var chain = PropertyChainFromExp.Get (Property);
				SourceSetValue (
					PropertyChainFromExp.GetChainName (chain),
					TargetGetValue (chain)
				);
			}
		}

		public BindingSource<TSource, TWidget> AddBinding<TSource>(TSource source, Expression<Func<TSource, object>> sourceProperty, Expression<Func<TWidget, object>> targetProperty)
			where TSource : class, INotifyPropertyChanged
		{
			var sourceControl = AddSource (source);
			sourceControl.AddBinding (sourceProperty, targetProperty);
			return sourceControl;
		}

		public BindingSource<TSource, TWidget> AddFuncBinding<TSource>(TSource source, Expression<Func<TSource, object>> sourceProperty, Expression<Func<TWidget, object>> targetProperty)
			where TSource : class, INotifyPropertyChanged
		{
			var sourceControl = AddSource (source);
			sourceControl.AddFuncBinding (sourceProperty, targetProperty);
			return sourceControl;
		}

		public BindingSource<TSource, TWidget> AddSource<TSource>(TSource source)
			where TSource : class, INotifyPropertyChanged
		{
			BindingSource<TSource, TWidget> bSource = Sources.Find (s => s.DataSourceObject == source) as BindingSource<TSource, TWidget>;
			if(bSource == null)
				bSource = new BindingSource<TSource, TWidget> (this, source);
			Sources.Add (bSource);
			return bSource;
		}

		public void InitializeFromSource()
		{
			Sources.ForEach (s => s.RunInitializeFromSource());
		}
	}
}

