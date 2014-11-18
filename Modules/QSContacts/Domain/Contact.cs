﻿using System;
using QSOrmProject;
using System.Collections.Generic;
using System.Data.Bindings;

namespace QSContacts
{
	[OrmSubjectAttibutes("Контактные лица")]
	public class Contact : BaseNotifyPropertyChanged, IDomainObject
	{
		#region Свойства
		public virtual int Id { get; set; }
		public virtual string Name { get; set; }
		public virtual string Surname { get; set; }
		public virtual string Lastname { get; set; }
		public virtual string Comment { get; set; }
		public virtual bool Fired { get; set; }
		public virtual Post Post { get; set; }
		public virtual IList<QSContacts.Phone> Phones { get; set; }
		public virtual IList<QSContacts.Email> Emails { get; set; }
		#endregion

		public Contact ()
		{
			Name = String.Empty;
			Surname = String.Empty;
			Lastname = String.Empty;
			Comment = String.Empty;
			Fired = false;
		}
		public string FullName { get { return String.Format("{0} {1} {2}", Surname, Name, Lastname); } }
		public string PostName { get { return Post.Name; } }

		public override bool Equals(Object obj)
		{
			Contact contactObj = obj as Contact; 
			if (contactObj == null)
				return false;
			else
				return Id.Equals(contactObj.Id);
		}

		public override int GetHashCode()
		{
			return this.Id.GetHashCode(); 
		}
	}
}
