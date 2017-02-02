
// This file has been generated by the GUI designer. Do not modify.
namespace QSFNS
{
	public partial class GetOrgInfo
	{
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Entry entryQuery;
		
		private global::Gtk.Button buttonFillFields;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget QSFNS.GetOrgInfo
			global::Stetic.BinContainer.Attach (this);
			this.Name = "QSFNS.GetOrgInfo";
			// Container child QSFNS.GetOrgInfo.Gtk.Container+ContainerChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Поиск по ФНС:");
			this.hbox1.Add (this.label1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label1]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryQuery = new global::Gtk.Entry ();
			this.entryQuery.TooltipMarkup = "Введите название, адрес, ИНН или ОГРН";
			this.entryQuery.CanFocus = true;
			this.entryQuery.Name = "entryQuery";
			this.entryQuery.IsEditable = true;
			this.entryQuery.InvisibleChar = '●';
			this.hbox1.Add (this.entryQuery);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryQuery]));
			w2.Position = 1;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonFillFields = new global::Gtk.Button ();
			this.buttonFillFields.CanFocus = true;
			this.buttonFillFields.Name = "buttonFillFields";
			this.buttonFillFields.UseUnderline = true;
			this.buttonFillFields.Label = global::Mono.Unix.Catalog.GetString ("Заполнить карточку");
			this.hbox1.Add (this.buttonFillFields);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonFillFields]));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.Add (this.hbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.entryQuery.TextInserted += new global::Gtk.TextInsertedHandler (this.OnEntryQueryTextInserted);
			this.entryQuery.TextDeleted += new global::Gtk.TextDeletedHandler (this.OnEntryQueryTextDeleted);
		}
	}
}
