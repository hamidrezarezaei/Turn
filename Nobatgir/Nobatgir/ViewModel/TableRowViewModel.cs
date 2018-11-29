using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

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

        private string _columnName;

        public T Row { get; set; }

        public string ColumnName
        {
            get => "Row." + _columnName;
            set => _columnName = value;
        }

        public string ClassName { get; set; }

        public ActionTypes ActionType { get; set; }
    }

}
