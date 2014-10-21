
// This file has been generated by the GUI designer. Do not modify.
namespace QSPhones
{
	public partial class PhonesView
	{
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.DataBindings.DataTable datatable1;
		
		private global::Gtk.Button buttonDelete;
		
		private global::Gtk.DataBindings.DataComboBox comboType;
		
		private global::Gtk.DataBindings.DataEntry entryAdditional;
		
		private global::Gtk.DataBindings.DataEntry entryPhone;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Button buttonAdd;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSPhones.PhonesView
			global::Stetic.BinContainer.Attach (this);
			this.Name = "QSPhones.PhonesView";
			// Container child QSPhones.PhonesView.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.datatable1 = new global::Gtk.DataBindings.DataTable (((uint)(1)), ((uint)(6)), false);
			this.datatable1.Name = "datatable1";
			this.datatable1.ColumnSpacing = ((uint)(6));
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			this.datatable1.InheritedDataSource = false;
			this.datatable1.InheritedBoundaryDataSource = false;
			// Container child datatable1.Gtk.Table+TableChild
			this.buttonDelete = new global::Gtk.Button ();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			global::Gtk.Image w1 = new global::Gtk.Image ();
			w1.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.buttonDelete.Image = w1;
			this.datatable1.Add (this.buttonDelete);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.buttonDelete]));
			w2.LeftAttach = ((uint)(5));
			w2.RightAttach = ((uint)(6));
			w2.XOptions = ((global::Gtk.AttachOptions)(0));
			w2.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable1.Gtk.Table+TableChild
			this.comboType = new global::Gtk.DataBindings.DataComboBox ();
			this.comboType.WidthRequest = 100;
			this.comboType.CanFocus = true;
			this.comboType.Name = "comboType";
			this.comboType.InheritedDataSource = true;
			this.comboType.Mappings = "NumberType";
			this.comboType.ColumnMappings = "{QSPhones.PhoneType} Name[Имя]";
			this.comboType.InheritedBoundaryDataSource = false;
			this.comboType.CursorPointsEveryType = false;
			this.comboType.InheritedDataSource = true;
			this.comboType.Mappings = "NumberType";
			this.comboType.InheritedBoundaryDataSource = false;
			this.datatable1.Add (this.comboType);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.comboType]));
			w3.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryAdditional = new global::Gtk.DataBindings.DataEntry ();
			this.entryAdditional.WidthRequest = 50;
			this.entryAdditional.CanFocus = true;
			this.entryAdditional.Name = "entryAdditional";
			this.entryAdditional.IsEditable = true;
			this.entryAdditional.InvisibleChar = '●';
			this.entryAdditional.InheritedDataSource = true;
			this.entryAdditional.Mappings = "Additional";
			this.entryAdditional.InheritedBoundaryDataSource = false;
			this.entryAdditional.InheritedDataSource = true;
			this.entryAdditional.Mappings = "Additional";
			this.entryAdditional.InheritedBoundaryDataSource = false;
			this.entryAdditional.Editable = false;
			this.datatable1.Add (this.entryAdditional);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.entryAdditional]));
			w4.LeftAttach = ((uint)(4));
			w4.RightAttach = ((uint)(5));
			w4.XOptions = ((global::Gtk.AttachOptions)(0));
			w4.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable1.Gtk.Table+TableChild
			this.entryPhone = new global::Gtk.DataBindings.DataEntry ();
			this.entryPhone.CanFocus = true;
			this.entryPhone.Name = "entryPhone";
			this.entryPhone.IsEditable = true;
			this.entryPhone.WidthChars = 19;
			this.entryPhone.InvisibleChar = '●';
			this.entryPhone.InheritedDataSource = true;
			this.entryPhone.Mappings = "Number";
			this.entryPhone.InheritedBoundaryDataSource = false;
			this.entryPhone.InheritedDataSource = true;
			this.entryPhone.Mappings = "Number";
			this.entryPhone.InheritedBoundaryDataSource = false;
			this.entryPhone.Editable = false;
			this.datatable1.Add (this.entryPhone);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.entryPhone]));
			w5.LeftAttach = ((uint)(2));
			w5.RightAttach = ((uint)(3));
			w5.XOptions = ((global::Gtk.AttachOptions)(0));
			w5.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 1F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("+7");
			this.datatable1.Add (this.label1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label1]));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(0));
			w6.YOptions = ((global::Gtk.AttachOptions)(0));
			// Container child datatable1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("доб.");
			this.datatable1.Add (this.label2);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.datatable1 [this.label2]));
			w7.LeftAttach = ((uint)(3));
			w7.RightAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(0));
			w7.YOptions = ((global::Gtk.AttachOptions)(0));
			this.vbox1.Add (this.datatable1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.datatable1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = global::Mono.Unix.Catalog.GetString ("Добавить");
			global::Gtk.Image w9 = new global::Gtk.Image ();
			w9.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.buttonAdd.Image = w9;
			this.vbox1.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonAdd]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.entryPhone.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntryPhoneTextInserted);
			this.entryPhone.TextDeleted += new global::Gtk.TextDeletedHandler (this.OnEntryPhoneTextDeleted);
			this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
			this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
		}
	}
}
