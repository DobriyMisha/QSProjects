
// This file has been generated by the GUI designer. Do not modify.
namespace QSProjectsLib
{
	public partial class WaitOperationDlg
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label labelMsg;
		
		private global::Gtk.ProgressBar progressbar1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSProjectsLib.WaitOperationDlg
			this.Name = "QSProjectsLib.WaitOperationDlg";
			this.Title = global::Mono.Unix.Catalog.GetString ("Ждем-с...");
			this.TypeHint = ((global::Gdk.WindowTypeHint)(1));
			this.WindowPosition = ((global::Gtk.WindowPosition)(3));
			this.Resizable = false;
			this.DestroyWithParent = true;
			this.SkipTaskbarHint = true;
			// Container child QSProjectsLib.WaitOperationDlg.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Пожалуйста, подождите.");
			this.label1.Justify = ((global::Gtk.Justification)(2));
			this.vbox2.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelMsg = new global::Gtk.Label ();
			this.labelMsg.Name = "labelMsg";
			this.labelMsg.LabelProp = global::Mono.Unix.Catalog.GetString ("Выполняется длительная операция.");
			this.vbox2.Add (this.labelMsg);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelMsg]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.progressbar1 = new global::Gtk.ProgressBar ();
			this.progressbar1.Name = "progressbar1";
			this.vbox2.Add (this.progressbar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.progressbar1]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 322;
			this.DefaultHeight = 84;
			this.Show ();
		}
	}
}