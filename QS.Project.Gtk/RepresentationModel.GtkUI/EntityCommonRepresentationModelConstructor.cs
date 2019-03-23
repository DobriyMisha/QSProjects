﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Gamma.ColumnConfig;
using QS.DomainModel.Entity;
using QS.Dialog.Gtk;
using QS.DomainModel.UoW;
using QS.Tools;
using NHibernate.Criterion;

namespace QS.RepresentationModel.GtkUI
{
	public class EntityCommonRepresentationModelConstructor<TEntity>
		where TEntity : class, IDomainObject, new()
	{
		private readonly Dictionary<string, Expression<Func<TEntity, string>>> columnsFields = new Dictionary<string, Expression<Func<TEntity, string>>>();
		private readonly List<Expression<Func<TEntity, string>>> searchFields = new List<Expression<Func<TEntity, string>>>();
		private readonly List<OrderByField<TEntity>> ordersFields = new List<OrderByField<TEntity>>();
		private ICriterion fixedRestriction;
		private IQueryFilter queryFilter;
		private IJournalFilter journalFilter;

		private IColumnsConfig ColumnsConfig;

		public EntityCommonRepresentationModelConstructor<TEntity> AddColumn(string name, Expression<Func<TEntity, string>> columnFuncExpr)
		{
			columnsFields.Add(name, columnFuncExpr);
			return this;
		}

		public EntityCommonRepresentationModelConstructor<TEntity> AddSearchColumn(string name, Expression<Func<TEntity, string>> columnFuncExpr)
		{
			columnsFields.Add(name, columnFuncExpr);
			searchFields.Add(columnFuncExpr);
			return this;
		}

		public EntityCommonRepresentationModelConstructor<TEntity> SetFixedRestriction(ICriterion criterion)
		{
			fixedRestriction = criterion;
			return this;
		}

		public EntityCommonRepresentationModelConstructor<TEntity> SetQueryFilter(IQueryFilterView filterView)
		{
			queryFilter = filterView.GetQueryFilter();
			journalFilter = filterView;
			return this;
		}

		public EntityCommonRepresentationModelConstructor<TEntity> OrderBy(Expression<Func<TEntity, object>> orderFuncExpr)
		{
			ordersFields.Add(new OrderByField<TEntity>(orderFuncExpr, false));
			return this;
		}

		public EntityCommonRepresentationModelConstructor<TEntity> OrderByDesc(Expression<Func<TEntity, object>> orderFuncExpr)
		{
			ordersFields.Add(new OrderByField<TEntity>(orderFuncExpr, true));
			return this;
		}

		private IColumnsConfig GetGammaColumnsConfig()
		{
			var config = FluentColumnsConfig<TEntity>.Create();
			foreach(var pair in columnsFields) {
				if(searchFields.Contains(pair.Value))
					config.AddColumn(pair.Key).AddTextRenderer(pair.Value).SearchHighlight();
				else
					config.AddColumn(pair.Key).AddTextRenderer(pair.Value);
			}
			return config.Finish();
		}

		public IRepresentationModel Finish()
		{
			var resultVM = new EntityCommonRepresentationModel<TEntity>(GetGammaColumnsConfig());
			resultVM.QueryFilter = queryFilter;
			resultVM.JournalFilter = journalFilter;
			resultVM.FixedRestriction = fixedRestriction;
			resultVM.Orders = ordersFields;
			return resultVM;
		}
	}

	public class OrderByField<TEntity>
		where TEntity : class, IDomainObject, new()
	{
		public Expression<Func<TEntity, object>> orderExpr { get; private set; }
		public bool IsDesc { get; private set; }

		public OrderByField(Expression<Func<TEntity, object>> orderExpr, bool desc)
		{
			this.orderExpr = orderExpr;
			IsDesc = desc;
		}
	}
}
