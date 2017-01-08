﻿using System;
using System.ComponentModel.DataAnnotations;
using QSOrmProject;
using QSProjectsLib;

namespace QSContacts
{
	[OrmSubject("Человек")]
	public class Person : PropertyChangedBase
	{
		#region Свойства
		public virtual int Id { get; set; }

		string name;

		[Display (Name = "Имя")]
		public virtual string Name {
			get { return name; }
			set { SetField (ref name, value?.Trim(), () => Name); }
		}

		string lastName;

		[Display (Name = "Фамилия")]
		public virtual string Lastname {
			get { return lastName; }
			set { SetField (ref lastName, value?.Trim(), () => Lastname); }
		}

		string patronymic;

		[Display (Name = "Отчество")]
		public virtual string PatronymicName {
			get { return patronymic; }
			set { SetField (ref patronymic, value?.Trim(), () => PatronymicName); }
		}
		#endregion

		public string NameWithInitials{
			get { return StringWorks.PersonNameWithInitials (Lastname, Name, PatronymicName);
			}
		}

	}
}

