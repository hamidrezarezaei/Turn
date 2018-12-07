using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Nobatgir.Model
{

    public class TableRowViewModel<T> where T : BaseClass
    {
        public TableRowViewModel(T row, string columnName, ActionTypes actionType, string classname = "")
        {
            this.Row = row;
            this.ColumnName = columnName;
            this.ActionType = actionType;
            this.ClassName = classname;
        }

        public TableRowViewModel(DetailsViewModel<T> dvm, string columnName, string classname = "")
        {
            this.Row = dvm.Row;
            this.ColumnName = columnName;
            this.ActionType = dvm.ActionType;
            this.ClassName = classname;
        }

        public TableRowViewModel(DetailsViewModel<T> dvm, string columnName, SelectList selectList, string selectListColumnName, string classname = "")
        :this(dvm, columnName, classname)
        {
            this.SelectList = selectList;
            this.SelectListColumnName = selectListColumnName;
            this.IsList = true;
        }

        private string _columnName;
        private string _selectListColumnName = null;

        public T Row { get; set; }

        public string ColumnName
        {
            get => "Row." + _columnName;
            set => _columnName = value;
        }

        public string ClassName { get; set; }

        public bool IsList { get; set; }

        public SelectList SelectList { get; set; }

        public string SelectListColumnName
        {
            get => "Row." + _selectListColumnName;
            set => _selectListColumnName = value;
        }

        public ActionTypes ActionType { get; set; }
    }

}
