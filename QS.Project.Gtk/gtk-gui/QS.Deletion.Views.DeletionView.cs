
// This file has been generated by the GUI designer. Do not modify.
namespace QS.Deletion.Views
{
	public partial class DeletionView
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Image image5602;

		private global::Gtk.Label label4;

		private global::Gtk.Notebook notebook1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewObjects;

		private global::Gtk.Label label1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow1;

		private global::Gamma.GtkWidgets.yTreeView ytreeviewDependence;

		private global::Gtk.Label label2;

		private global::Gtk.HBox hbox1;

		private global::Gamma.GtkWidgets.yButton buttonDelete;

		private global::Gamma.GtkWidgets.yButton buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QS.Deletion.Views.DeletionView
			global::Stetic.BinContainer.Attach(this);
			this.WidthRequest = 700;
			this.HeightRequest = 460;
			this.Name = "QS.Deletion.Views.DeletionView";
			// Container child QS.Deletion.Views.DeletionView.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.image5602 = new global::Gtk.Image();
			this.image5602.Name = "image5602";
			this.image5602.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Dialog);
			this.hbox6.Add(this.image5602);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.image5602]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Вы уверены что хотите удалить объект? Операция необратима.\nВместе с ним также буд" +
					"ут удалены или очищены ссылки в следующих объектах:");
			this.hbox6.Add(this.label4);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.label4]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			this.vbox2.Add(this.hbox6);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox6]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.ytreeviewObjects = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewObjects.CanFocus = true;
			this.ytreeviewObjects.Name = "ytreeviewObjects";
			this.GtkScrolledWindow.Add(this.ytreeviewObjects);
			this.notebook1.Add(this.GtkScrolledWindow);
			// Notebook tab
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Удаляемые объекты");
			this.notebook1.SetTabLabel(this.GtkScrolledWindow, this.label1);
			this.label1.ShowAll();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.ytreeviewDependence = new global::Gamma.GtkWidgets.yTreeView();
			this.ytreeviewDependence.CanFocus = true;
			this.ytreeviewDependence.Name = "ytreeviewDependence";
			this.GtkScrolledWindow1.Add(this.ytreeviewDependence);
			this.notebook1.Add(this.GtkScrolledWindow1);
			global::Gtk.Notebook.NotebookChild w7 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1[this.GtkScrolledWindow1]));
			w7.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Дерево зависимостей");
			this.notebook1.SetTabLabel(this.GtkScrolledWindow1, this.label2);
			this.label2.ShowAll();
			this.vbox2.Add(this.notebook1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.notebook1]));
			w8.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gamma.GtkWidgets.yButton();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w9 = new global::Gtk.Image();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDelete.Image = w9;
			this.hbox1.Add(this.buttonDelete);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonDelete]));
			w10.PackType = ((global::Gtk.PackType)(1));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonCancel = new global::Gamma.GtkWidgets.yButton();
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Отмена");
			global::Gtk.Image w11 = new global::Gtk.Image();
			w11.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w11;
			this.hbox1.Add(this.buttonCancel);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonCancel]));
			w12.PackType = ((global::Gtk.PackType)(1));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
			this.buttonCancel.Clicked += new global::System.EventHandler(this.OnButtonCancelClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler(this.OnButtonDeleteClicked);
		}
	}
}