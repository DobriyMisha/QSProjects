
// This file has been generated by the GUI designer. Do not modify.
namespace QSProjectsLib
{
	public partial class UserProperty
	{
		private global::Gtk.HBox hbox2;
		private global::Gtk.VBox vbox3;
		private global::Gtk.Table table1;
		private global::Gtk.Entry entryID;
		private global::Gtk.Entry entryLogin;
		private global::Gtk.Entry entryName;
		private global::Gtk.Entry entryPassword;
		private global::Gtk.Label label2;
		private global::Gtk.Label label3;
		private global::Gtk.Label label4;
		private global::Gtk.Label label6;
		private global::Gtk.VBox vbox4;
		private global::Gtk.Frame frame1;
		private global::Gtk.Alignment GtkAlignment2;
		private global::Gtk.VBox vboxPermissions;
		private global::Gtk.CheckButton checkAdmin;
		private global::Gtk.Label GtkLabel4;
		private global::Gtk.Label label5;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textviewComments;
		private global::Gtk.Button buttonCancel;
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSProjectsLib.UserProperty
			this.Name = "QSProjectsLib.UserProperty";
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child QSProjectsLib.UserProperty.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(9));
			// Container child table1.Gtk.Table+TableChild
			this.entryID = new global::Gtk.Entry ();
			this.entryID.Sensitive = false;
			this.entryID.CanFocus = true;
			this.entryID.Name = "entryID";
			this.entryID.IsEditable = true;
			this.entryID.InvisibleChar = '●';
			this.table1.Add (this.entryID);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryID]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryLogin = new global::Gtk.Entry ();
			this.entryLogin.CanFocus = true;
			this.entryLogin.Name = "entryLogin";
			this.entryLogin.IsEditable = true;
			this.entryLogin.InvisibleChar = '●';
			this.table1.Add (this.entryLogin);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryLogin]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryPassword = new global::Gtk.Entry ();
			this.entryPassword.TooltipMarkup = "Не вводите пароль на русском языке, это может не работать.";
			this.entryPassword.CanFocus = true;
			this.entryPassword.Name = "entryPassword";
			this.entryPassword.IsEditable = true;
			this.entryPassword.Visibility = false;
			this.entryPassword.InvisibleChar = '●';
			this.table1.Add (this.entryPassword);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryPassword]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Код:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Логин:");
			this.table1.Add (this.label3);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1 [this.label3]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Имя:");
			this.table1.Add (this.label4);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.label4]));
			w8.TopAttach = ((uint)(1));
			w8.BottomAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Пароль:");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w9.TopAttach = ((uint)(3));
			w9.BottomAttach = ((uint)(4));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox3.Add (this.table1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table1]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			this.vbox3.Add (this.vbox4);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.vbox4]));
			w11.Position = 1;
			this.hbox2.Add (this.vbox3);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox3]));
			w12.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.frame1 = new global::Gtk.Frame ();
			this.frame1.Name = "frame1";
			this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child frame1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.vboxPermissions = new global::Gtk.VBox ();
			this.vboxPermissions.Name = "vboxPermissions";
			this.vboxPermissions.Spacing = 6;
			// Container child vboxPermissions.Gtk.Box+BoxChild
			this.checkAdmin = new global::Gtk.CheckButton ();
			this.checkAdmin.CanFocus = true;
			this.checkAdmin.Name = "checkAdmin";
			this.checkAdmin.Label = global::Mono.Unix.Catalog.GetString ("Администрирование");
			this.checkAdmin.DrawIndicator = true;
			this.checkAdmin.UseUnderline = true;
			this.vboxPermissions.Add (this.checkAdmin);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxPermissions [this.checkAdmin]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			this.GtkAlignment2.Add (this.vboxPermissions);
			this.frame1.Add (this.GtkAlignment2);
			this.GtkLabel4 = new global::Gtk.Label ();
			this.GtkLabel4.Name = "GtkLabel4";
			this.GtkLabel4.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Права пользователя</b>");
			this.GtkLabel4.UseMarkup = true;
			this.frame1.LabelWidget = this.GtkLabel4;
			this.hbox2.Add (this.frame1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.frame1]));
			w16.Position = 1;
			w1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(w1 [this.hbox2]));
			w17.Position = 0;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Комментарии</b>");
			this.label5.UseMarkup = true;
			w1.Add (this.label5);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(w1 [this.label5]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewComments = new global::Gtk.TextView ();
			this.textviewComments.CanFocus = true;
			this.textviewComments.Name = "textviewComments";
			this.textviewComments.WrapMode = ((global::Gtk.WrapMode)(2));
			this.GtkScrolledWindow.Add (this.textviewComments);
			w1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(w1 [this.GtkScrolledWindow]));
			w20.Position = 2;
			// Internal child QSProjectsLib.UserProperty.ActionArea
			global::Gtk.HButtonBox w21 = this.ActionArea;
			w21.Name = "dialog1_ActionArea";
			w21.Spacing = 10;
			w21.BorderWidth = ((uint)(5));
			w21.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("О_тменить");
			global::Gtk.Image w22 = new global::Gtk.Image ();
			w22.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-cancel", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w22;
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w23 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w21 [this.buttonCancel]));
			w23.Expand = false;
			w23.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = global::Mono.Unix.Catalog.GetString ("_OK");
			global::Gtk.Image w24 = new global::Gtk.Image ();
			w24.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-ok", global::Gtk.IconSize.Menu);
			this.buttonOk.Image = w24;
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w25 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w21 [this.buttonOk]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 530;
			this.DefaultHeight = 347;
			this.Show ();
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
