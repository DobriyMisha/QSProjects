
// This file has been generated by the GUI designer. Do not modify.
namespace QSReport
{
	public partial class ReportViewDlg
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.HBox hbox1;
		
		private global::QSWidgetLib.LeftSidePanel panelParameters;
		
		private global::fyiReporting.RdlGtkViewer.ReportViewer reportviewer1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSReport.ReportViewDlg
			Stetic.BinContainer w1 = global::Stetic.BinContainer.Attach (this);
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w2 = new global::Gtk.ActionGroup ("Default");
			this.UIManager.InsertActionGroup (w2, 0);
			this.Name = "QSReport.ReportViewDlg";
			// Container child QSReport.ReportViewDlg.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.panelParameters = new global::QSWidgetLib.LeftSidePanel ();
			this.panelParameters.Events = ((global::Gdk.EventMask)(256));
			this.panelParameters.Name = "panelParameters";
			this.panelParameters.Title = "Параметры";
			this.panelParameters.IsHided = false;
			this.hbox1.Add (this.panelParameters);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.panelParameters]));
			w3.Position = 0;
			w3.Expand = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.reportviewer1 = new global::fyiReporting.RdlGtkViewer.ReportViewer ();
			this.reportviewer1.WidthRequest = 0;
			this.reportviewer1.HeightRequest = 0;
			this.reportviewer1.Events = ((global::Gdk.EventMask)(256));
			this.reportviewer1.Name = "reportviewer1";
			this.reportviewer1.ShowErrors = false;
			this.reportviewer1.ShowParameters = false;
			this.hbox1.Add (this.reportviewer1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.reportviewer1]));
			w4.Position = 1;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			w1.SetUiManager (UIManager);
			this.Hide ();
		}
	}
}
