﻿using System;

namespace GammaBinding
{
	public interface IBindingSource
	{
		BindingBridge[] AllBridges { get;}
		IBindingControler Controler{ get;}

		BindingBridge[] GetBackwardBridges(string targetPropName);
		object GetValueFromSource(BindingBridge bridge);
		bool SetValueToSource(BindingBridge bridge, object value);
		void InitializeFromSource();
	}
}
