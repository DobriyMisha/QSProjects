
// This file has been generated by the GUI designer. Do not modify.
namespace QSWidgetLib
{
	public partial class LegalName
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.ComboBox comboOwnership;
		
		private global::Gtk.Entry entryName;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSWidgetLib.LegalName
			global::Stetic.BinContainer.Attach (this);
			this.Name = "QSWidgetLib.LegalName";
			// Container child QSWidgetLib.LegalName.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboOwnership = global::Gtk.ComboBox.NewText ();
			this.comboOwnership.Name = "comboOwnership";
			this.hbox1.Add (this.comboOwnership);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboOwnership]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.hbox1.Add (this.entryName);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryName]));
			w2.Position = 1;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.comboOwnership.Changed += new global::System.EventHandler (this.OnComboOwnershipChanged);
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
		}
	}
}