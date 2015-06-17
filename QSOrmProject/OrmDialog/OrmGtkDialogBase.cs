﻿using System;
using System.Data.Bindings;
using Gtk;
using QSProjectsLib;
using QSTDI;

namespace QSOrmProject
{
	public abstract class OrmGtkDialogBase<TEntity> : Bin, ITdiDialog, IOrmDialogNew, IOrmDialog 
		where TEntity : IDomainObject, new()
	{
		public IUnitOfWork UoW {
			get
			{
				return UoWGeneric;
			}
		}

		private IUnitOfWorkGeneric<TEntity> uowGeneric;

		public IUnitOfWorkGeneric<TEntity> UoWGeneric {
			get
			{
				return uowGeneric;
			}
			protected set
			{
				uowGeneric = value;
				subjectAdaptor.Target = UoWGeneric.Root;
				OnTabNameChanged();
			}
		}


		//FIXME Временно для совместимости
		public NHibernate.ISession Session
		{
			get
			{
				return UoW.Session;
			}
		}

		public virtual bool HasChanges { 
			get { return UoWGeneric.HasChanges; }
		}

		public object Subject {
			get { return UoWGeneric.Root; }
		}
			
		private string tabName = String.Empty;

		public string TabName {
			get {
				if(!String.IsNullOrWhiteSpace(tabName))
					return tabName;
				if (UoW != null)
				{
					if(UoW.IsNew)
					{
						var att = typeof(TEntity).GetCustomAttributes (typeof(OrmSubjectAttribute), true);
						if (att.Length > 0 && !String.IsNullOrWhiteSpace((att [0] as OrmSubjectAttribute).ObjectName))
						{
							var subAtt = (att [0] as OrmSubjectAttribute);

							switch(subAtt.AllNames.Gender){
								case GrammaticalGender.Masculine: 
									return "Новый " + subAtt.ObjectName;
								case GrammaticalGender.Feminine :
									return "Новая " + subAtt.ObjectName;
								case GrammaticalGender.Neuter :
									return "Новое " + subAtt.ObjectName;
								default:
									return "Новый(ая) " + subAtt.ObjectName;
							}
						}
							
					}
					else
					{
						return DomainHelper.GetObjectTilte(UoW.RootObject);
					}
				}

				return String.Empty;
			}
			set {
				if (tabName == value)
					return;
				tabName = value;
				OnTabNameChanged();
			}

		}

		public abstract bool Save ();

		public ITdiTabParent TabParent { set; get; }

		public event EventHandler<TdiTabNameChangedEventArgs> TabNameChanged;
		public event EventHandler<TdiTabCloseEventArgs> CloseTab;

		protected void OnCloseTab (bool askSave)
		{
			if (CloseTab != null)
				CloseTab (this, new TdiTabCloseEventArgs (askSave));
		}

		protected Adaptor subjectAdaptor = new Adaptor ();

		protected void OnButtonSaveClicked (object sender, EventArgs e)
		{
			if (!this.HasChanges || Save ())
				OnCloseTab (false);
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			OnCloseTab (false);
		}

		public override void Destroy ()
		{
			UoWGeneric.Dispose();
			subjectAdaptor.Disconnect ();
			base.Destroy ();
		}

		protected void OnTabNameChanged()
		{
			if (TabNameChanged != null)
				TabNameChanged (this, new TdiTabNameChangedEventArgs (TabName));
		}

		public OrmGtkDialogBase()
		{
		}
	}
}
