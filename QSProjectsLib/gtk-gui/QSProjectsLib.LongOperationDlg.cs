
// This file has been generated by the GUI designer. Do not modify.
namespace QSProjectsLib
{
	public partial class LongOperationDlg
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label labelMsg;
		
		private global::Gtk.ProgressBar progressbar1;
		
		private global::Gtk.Button buttonCancel;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSProjectsLib.LongOperationDlg
			this.Name = "QSProjectsLib.LongOperationDlg";
			this.Title = global::Mono.Unix.Catalog.GetString ("LongOperationStatusWindow");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child QSProjectsLib.LongOperationDlg.Gtk.Container+ContainerChild
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
			this.progressbar1.Text = global::Mono.Unix.Catalog.GetString ("Накладная #107 (1/27)");
			this.vbox2.Add (this.progressbar1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.progressbar1]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Отмена");
			global::Gtk.Image w4 = new global::Gtk.Image ();
			this.buttonCancel.Image = w4;
			this.vbox2.Add (this.buttonCancel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.buttonCancel]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 3;
			w5.Expand = false;
			w5.Fill = false;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 391;
			this.DefaultHeight = 125;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
		}
	}
}
