using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Nobatgir.Model;
using Nobatgir.Services;

namespace Nobatgir.ViewModel
{
    public class TurnFieldsViewModel
    {
        public bool IsVeify { get; set; }

        public Model.Turn Turn { get; set; }

        public List<ExpertFieldsViewModel> ExpertFields { get; set; }
    }

    public class ExpertFieldsViewModel : ExpertField
    {
        /// <summary>
        /// مقادیر فهرست برای ساخت combobox
        /// </summary>
        public SelectList SourceValues
        {
            get
            {
                if (this.SourceTypeID == null)
                    return null;

                var lst = this.SourceType.SourceValues.Where(x => !x.IsDeleted && x.IsActive)
                    .OrderBy(x => x.OrderIndex);

                return new SelectList(lst, nameof(ID), nameof(Title));
            }
        }
    }
}
