
// This file has been generated by the GUI designer. Do not modify.
namespace QS.Project.Dialogs.GtkUI
{
	public partial class UsersDialog
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.HBox hbox2;

		private global::Gtk.CheckButton chkShowInactive;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gamma.GtkWidgets.yTreeView treeviewUsers;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button buttonAdd;

		private global::Gtk.Button buttonEdit;

		private global::Gtk.Button buttonDelete;

		private global::Gtk.Button buttonCancel;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget QS.Project.Dialogs.GtkUI.UsersDialog
			this.Name = "QS.Project.Dialogs.GtkUI.UsersDialog";
			this.Title = global::Mono.Unix.Catalog.GetString("Пользователи");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			// Internal child QS.Project.Dialogs.GtkUI.UsersDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.chkShowInactive = new global::Gtk.CheckButton();
			this.chkShowInactive.CanFocus = true;
			this.chkShowInactive.Name = "chkShowInactive";
			this.chkShowInactive.Label = global::Mono.Unix.Catalog.GetString("Показывать отключённых пользователей");
			this.chkShowInactive.DrawIndicator = true;
			this.chkShowInactive.UseUnderline = true;
			this.hbox2.Add(this.chkShowInactive);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.chkShowInactive]));
			w2.PackType = ((global::Gtk.PackType)(1));
			w2.Position = 0;
			this.vbox2.Add(this.hbox2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewUsers = new global::Gamma.GtkWidgets.yTreeView();
			this.treeviewUsers.CanFocus = true;
			this.treeviewUsers.Name = "treeviewUsers";
			this.GtkScrolledWindow.Add(this.treeviewUsers);
			this.vbox2.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.GtkScrolledWindow]));
			w5.Position = 1;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = global::Mono.Unix.Catalog.GetString("Создать");
			global::Gtk.Image w6 = new global::Gtk.Image();
			w6.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAdd.Image = w6;
			this.hbox1.Add(this.buttonAdd);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonAdd]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonEdit = new global::Gtk.Button();
			this.buttonEdit.CanFocus = true;
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.UseUnderline = true;
			this.buttonEdit.Label = global::Mono.Unix.Catalog.GetString("Изменить");
			global::Gtk.Image w8 = new global::Gtk.Image();
			w8.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-edit", global::Gtk.IconSize.Menu);
			this.buttonEdit.Image = w8;
			this.hbox1.Add(this.buttonEdit);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonEdit]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString("Удалить");
			global::Gtk.Image w10 = new global::Gtk.Image();
			w10.Pixbuf = global::Stetic.IconLoader.LoadIcon(this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDelete.Image = w10;
			this.hbox1.Add(this.buttonDelete);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.buttonDelete]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			this.vbox2.Add(this.hbox1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
			w12.Position = 2;
			w12.Expand = false;
			w12.Fill = false;
			w1.Add(this.vbox2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(w1[this.vbox2]));
			w13.Position = 0;
			// Internal child QS.Project.Dialogs.GtkUI.UsersDialog.ActionArea
			global::Gtk.HButtonBox w14 = this.ActionArea;
			w14.Name = "dialog1_ActionArea";
			w14.Spacing = 10;
			w14.BorderWidth = ((uint)(5));
			w14.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString("Закрыть");
			this.AddActionWidget(this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w14[this.buttonCancel]));
			w15.Expand = false;
			w15.Fill = false;
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.chkShowInactive.Toggled += new global::System.EventHandler(this.OnChkShowInactiveToggled);
			this.treeviewUsers.RowActivated += new global::Gtk.RowActivatedHandler(this.OnTreeviewUsersRowActivated);
			this.buttonAdd.Clicked += new global::System.EventHandler(this.OnButtonAddClicked);
			this.buttonEdit.Clicked += new global::System.EventHandler(this.OnButtonEditClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler(this.OnButtonDeleteClicked);
		}
	}
}
