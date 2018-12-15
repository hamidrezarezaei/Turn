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
        public async Task<IViewComponentResult> InvokeAsync(Guid TurnID, string ViewName = "Default")
        {
            var fields = _repository.GetListActiveByParent<ExpertField, int>(x => x.ExpertID, _repository.ExpertID, x => x.SourceType);

            var t = _repository.GetTurn(TurnID);

            var m = new TurnFieldsViewModel { Turn = t, ExpertFields = fields.ToList() };

            return View(ViewName, m);
        }

        #endregion 
    }
}
