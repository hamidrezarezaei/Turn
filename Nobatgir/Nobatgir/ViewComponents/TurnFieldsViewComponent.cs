using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Nobatgir.Services;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Nobatgir.ViewComponents
{
    public class TurnFieldsViewComponent : ViewComponent
    {
        #region Constructor
        private readonly Repository _repository;

        public TurnFieldsViewComponent(Repository repository)
        {
            this._repository = repository;
        }
        #endregion

        #region Invoke
        public async Task<IViewComponentResult> InvokeAsync(Guid TurnID, bool IsVeify = false, string ViewName = "Default")
        {
            var fields = _repository.GetListActiveByParent<ExpertField, int>(x => x.ExpertID, _repository.ExpertID)
                .Include(x => x.SourceType).ThenInclude(x => x.SourceValues).ToList();

            var t = _repository.GetTurn(TurnID);

            var lst = fields.Select(x => new ExpertFieldsViewModel
            {
                ID = x.ID,
                Title = x.Title,
                CssClass = x.CssClass,
                Expert = x.Expert,
                ExpertID = x.ExpertID,
                FieldType = x.FieldType,
                IsActive = x.IsActive,
                IsDeleted = x.IsDeleted,
                Name = x.Name,
                OrderIndex = x.OrderIndex,
                Placeholder = x.Placeholder,
                SourceTypeID = x.SourceTypeID,
                UpdateDateTime = x.UpdateDateTime,
                UserID = x.UserID,
                Value = _repository.GetTurnDetailsTitle(t, x.ID, IsVeify) ?? x.Value,
                SourceType = x.SourceType
            }).ToList();

            var m = new TurnFieldsViewModel { Turn = t, ExpertFields = lst, IsVeify = IsVeify };

            return View(ViewName, m);
        }

        #endregion 
    }
}
