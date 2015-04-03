
// This file has been generated by the GUI designer. Do not modify.
namespace QSBanks
{
	public partial class AccountDlg
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Button buttonSave;
		
		private global::Gtk.Label labelInactive;
		
		private global::Gtk.DataBindings.DataTable datatableMain;
		
		private global::Gtk.DataBindings.DataEntry dataentryName;
		
		private global::QSOrmProject.DataValidatedEntry dataentryNumber;
		
		private global::Gtk.DataBindings.DataEntryReference dataentryrefBank;
		
		private global::Gtk.DataBindings.DataFrame dataframe1;
		
		private global::Gtk.Alignment GtkAlignment2;
		
		private global::Gtk.DataBindings.DataTable datatableBank;
		
		private global::Gtk.DataBindings.DataLabel datalabelBik;
		
		private global::Gtk.DataBindings.DataLabel datalabelCity;
		
		private global::Gtk.DataBindings.DataLabel datalabelRegion;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Label label3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSBanks.AccountDlg
			global::Stetic.BinContainer.Attach (this);
			this.Name = "QSBanks.AccountDlg";
			// Container child QSBanks.AccountDlg.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Закрыть");
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
			this.buttonSave.Image = w1;
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.labelInactive = new global::Gtk.Label ();
			this.labelInactive.Name = "labelInactive";
			this.labelInactive.Justify = ((global::Gtk.Justification)(2));
			this.hbox1.Add (this.labelInactive);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.labelInactive]));
			w3.Position = 1;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatableMain = new global::Gtk.DataBindings.DataTable (((uint)(4)), ((uint)(2)), false);
			this.datatableMain.Name = "datatableMain";
			this.datatableMain.RowSpacing = ((uint)(6));
			this.datatableMain.ColumnSpacing = ((uint)(6));
			this.datatableMain.InheritedDataSource = false;
			this.datatableMain.InheritedBoundaryDataSource = false;
			this.datatableMain.InheritedDataSource = false;
			this.datatableMain.InheritedBoundaryDataSource = false;
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryName = new global::Gtk.DataBindings.DataEntry ();
			this.dataentryName.CanFocus = true;
			this.dataentryName.Name = "dataentryName";
			this.dataentryName.IsEditable = true;
			this.dataentryName.InvisibleChar = '●';
			this.dataentryName.InheritedDataSource = true;
			this.dataentryName.Mappings = "Name";
			this.dataentryName.InheritedBoundaryDataSource = false;
			this.dataentryName.InheritedDataSource = true;
			this.dataentryName.Mappings = "Name";
			this.dataentryName.InheritedBoundaryDataSource = false;
			this.datatableMain.Add (this.dataentryName);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.dataentryName]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryNumber = new global::QSOrmProject.DataValidatedEntry ();
			this.dataentryNumber.CanFocus = true;
			this.dataentryNumber.Name = "dataentryNumber";
			this.dataentryNumber.IsEditable = true;
			this.dataentryNumber.MaxLength = 25;
			this.dataentryNumber.InvisibleChar = '●';
			this.dataentryNumber.InheritedDataSource = true;
			this.dataentryNumber.Mappings = "Number";
			this.dataentryNumber.InheritedBoundaryDataSource = false;
			this.datatableMain.Add (this.dataentryNumber);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.dataentryNumber]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataentryrefBank = new global::Gtk.DataBindings.DataEntryReference ();
			this.dataentryrefBank.Events = ((global::Gdk.EventMask)(256));
			this.dataentryrefBank.Name = "dataentryrefBank";
			this.dataentryrefBank.DisplayFields = new string[] {
				"Name"
			};
			this.dataentryrefBank.InheritedDataSource = true;
			this.dataentryrefBank.Mappings = "InBank";
			this.dataentryrefBank.InheritedBoundaryDataSource = false;
			this.dataentryrefBank.CursorPointsEveryType = false;
			this.datatableMain.Add (this.dataentryrefBank);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.dataentryrefBank]));
			w7.TopAttach = ((uint)(2));
			w7.BottomAttach = ((uint)(3));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.dataframe1 = new global::Gtk.DataBindings.DataFrame ();
			this.dataframe1.Name = "dataframe1";
			this.dataframe1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.dataframe1.InheritedDataSource = false;
			this.dataframe1.InheritedBoundaryDataSource = false;
			this.dataframe1.InheritedDataSource = false;
			this.dataframe1.InheritedBoundaryDataSource = false;
			// Container child dataframe1.Gtk.Container+ContainerChild
			this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
			this.GtkAlignment2.Name = "GtkAlignment2";
			this.GtkAlignment2.LeftPadding = ((uint)(12));
			// Container child GtkAlignment2.Gtk.Container+ContainerChild
			this.datatableBank = new global::Gtk.DataBindings.DataTable (((uint)(3)), ((uint)(2)), false);
			this.datatableBank.Name = "datatableBank";
			this.datatableBank.RowSpacing = ((uint)(6));
			this.datatableBank.ColumnSpacing = ((uint)(6));
			this.datatableBank.InheritedDataSource = false;
			this.datatableBank.InheritedBoundaryDataSource = false;
			this.datatableBank.InheritedDataSource = false;
			this.datatableBank.InheritedBoundaryDataSource = false;
			// Container child datatableBank.Gtk.Table+TableChild
			this.datalabelBik = new global::Gtk.DataBindings.DataLabel ();
			this.datalabelBik.Name = "datalabelBik";
			this.datalabelBik.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel1");
			this.datalabelBik.InheritedDataSource = true;
			this.datalabelBik.Mappings = "Bik";
			this.datalabelBik.InheritedBoundaryDataSource = false;
			this.datalabelBik.Important = false;
			this.datalabelBik.InheritedDataSource = true;
			this.datalabelBik.Mappings = "Bik";
			this.datalabelBik.InheritedBoundaryDataSource = false;
			this.datatableBank.Add (this.datalabelBik);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.datalabelBik]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableBank.Gtk.Table+TableChild
			this.datalabelCity = new global::Gtk.DataBindings.DataLabel ();
			this.datalabelCity.Name = "datalabelCity";
			this.datalabelCity.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel1");
			this.datalabelCity.InheritedDataSource = true;
			this.datalabelCity.Mappings = "City";
			this.datalabelCity.InheritedBoundaryDataSource = false;
			this.datalabelCity.Important = false;
			this.datalabelCity.InheritedDataSource = true;
			this.datalabelCity.Mappings = "City";
			this.datalabelCity.InheritedBoundaryDataSource = false;
			this.datatableBank.Add (this.datalabelCity);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.datalabelCity]));
			w9.TopAttach = ((uint)(2));
			w9.BottomAttach = ((uint)(3));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableBank.Gtk.Table+TableChild
			this.datalabelRegion = new global::Gtk.DataBindings.DataLabel ();
			this.datalabelRegion.Name = "datalabelRegion";
			this.datalabelRegion.LabelProp = global::Mono.Unix.Catalog.GetString ("datalabel2");
			this.datalabelRegion.InheritedDataSource = true;
			this.datalabelRegion.Mappings = "Region";
			this.datalabelRegion.InheritedBoundaryDataSource = false;
			this.datalabelRegion.Important = false;
			this.datalabelRegion.InheritedDataSource = true;
			this.datalabelRegion.Mappings = "Region";
			this.datalabelRegion.InheritedBoundaryDataSource = false;
			this.datatableBank.Add (this.datalabelRegion);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.datalabelRegion]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableBank.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.Xalign = 1F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("БИК:");
			this.datatableBank.Add (this.label4);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.label4]));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableBank.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 1F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Регион:");
			this.datatableBank.Add (this.label5);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.label5]));
			w12.TopAttach = ((uint)(1));
			w12.BottomAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableBank.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.Xalign = 1F;
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Город:");
			this.datatableBank.Add (this.label6);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.datatableBank [this.label6]));
			w13.TopAttach = ((uint)(2));
			w13.BottomAttach = ((uint)(3));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			this.GtkAlignment2.Add (this.datatableBank);
			this.dataframe1.Add (this.GtkAlignment2);
			this.datatableMain.Add (this.dataframe1);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.dataframe1]));
			w16.TopAttach = ((uint)(3));
			w16.BottomAttach = ((uint)(4));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Псевдоним:");
			this.datatableMain.Add (this.label1);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.label1]));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 1F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Номер:");
			this.datatableMain.Add (this.label2);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.label2]));
			w18.TopAttach = ((uint)(1));
			w18.BottomAttach = ((uint)(2));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child datatableMain.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 1F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("В банке:");
			this.datatableMain.Add (this.label3);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.datatableMain [this.label3]));
			w19.TopAttach = ((uint)(2));
			w19.BottomAttach = ((uint)(3));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox1.Add (this.datatableMain);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatableMain]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonSave.Clicked += new global::System.EventHandler (this.OnButtonSaveClicked);
			this.dataentryrefBank.Changed += new global::System.EventHandler (this.OnDataentryrefBankChanged);
		}
	}
}
