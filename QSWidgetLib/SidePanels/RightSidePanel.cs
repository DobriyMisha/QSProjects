﻿using System;

namespace QSWidgetLib
{
	[System.ComponentModel.ToolboxItem(true)]
	public partial class RightSidePanel : Gtk.Bin
	{
		Gtk.Widget panel;

		public Gtk.Widget Panel
		{
			get
			{
				return panel;
			}
			set
			{ 
				if (panel == value)
					return;
				if(panel != null)
				{
					hboxMain.Remove (panel);
				}
				panel = value;

				if(panel != null)
				{
					hboxMain. PackEnd (panel);
					hboxMain.ReorderChild (panel, 1);
					panel.Visible = !IsHided;
				}
			}
		}

		public string Title {
			get {
				return labelTitle.LabelProp;
			}
			set{ labelTitle.LabelProp = value;
			}
		}

		public bool IsHided
		{
			get
			{
				return arrowSlider.ArrowType == Gtk.ArrowType.Left;
			}
			set
			{
				if(value)
				{
					arrowSlider.ArrowType = Gtk.ArrowType.Left;
				}
				else
				{
					arrowSlider.ArrowType = Gtk.ArrowType.Right;
				}
				if(Panel != null)
					panel.Visible = !value;
			}
		}

		public RightSidePanel ()
		{
			this.Build ();
		}

		protected void OnEventboxArrowButtonPressEvent (object o, Gtk.ButtonPressEventArgs args)
		{
			IsHided = !IsHided;
		}
	}
}