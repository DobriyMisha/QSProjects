using System;
using System.Collections.Generic;

namespace QSOrmProject.Deletion
{

	public class DeleteInfo
	{
		public Type ObjectClass;
		public string ObjectsName;
		public string ObjectName;
		public string TableName;

		/// <summary>
		/// Запрос Select для отображения удаляемых записей, в запросе в строке FROM
		/// можно не указывать напрямую имя таблицы, а использовать @tablename, что 
		/// в случае использования ORM, позволяет переименовывать таблицу для класса
		/// без последствий для удаления. 
		/// </summary>
		public string SqlSelect;
		public string DisplayString;
		public List<DeleteDependenceInfo> DeleteItems;
		public List<ClearDependenceInfo> ClearItems;

		public string PreparedSqlSelect{
			get { //Заменяем название таблицы и добавляем пробел, если его нет.
				return SqlSelect.Replace ("@tablename", TableName).TrimEnd (' ') + " ";
			}
		}

		public DeleteInfo()
		{
			DeleteItems = new List<DeleteDependenceInfo>();
			ClearItems = new List<ClearDependenceInfo>();
		}

		/// <summary>
		/// Метод автоматически заполняет поля ObjectsName и ObjectName из атрибута OrmSubjectAttribute
		/// в классе. И заполняет TableName из настроек NhiberNate.
		/// </summary>
		/// <returns>The from meta info.</returns>
		public DeleteInfo FillFromMetaInfo()
		{
			if (ObjectClass == null)
				throw new NullReferenceException ("ObjectClass должен быть заполнен.");
			var attArray = ObjectClass.GetCustomAttributes (typeof(OrmSubjectAttribute), false);
			if(attArray.Length > 0)
			{
				if (String.IsNullOrEmpty (ObjectsName))
					ObjectsName = (attArray [0] as OrmSubjectAttribute).JournalName;
				if (String.IsNullOrEmpty (ObjectName))
					ObjectName = (attArray [0] as OrmSubjectAttribute).ObjectName;
			}

			if (String.IsNullOrEmpty (TableName) && OrmMain.ormConfig != null) {
				var maping = OrmMain.ormConfig.GetClassMapping (ObjectClass);
				if (maping != null) {
					TableName = maping.Table.Name;
				}
			}

			return this;
		}
	}
}
