using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nobatgir.Data;
using Nobatgir.Model;
using Nobatgir.ViewModel;

namespace Nobatgir.Services
{
    public enum Settings
    {
        ViewName, SiteTitle, Formula
    }

    public partial class Repository
    {
        public IEnumerable<ExpertSetting> GetExpertSettings()
        {
            return this._myContext.ExpertSettings.Where(x => x.ExpertID == this.ExpertID);
        }

        public ExpertSetting GetExpertSetting(int id)
        {
            return this._myContext.ExpertSettings.FirstOrDefault(x => x.ID == id);
        }

        public int AddExpertSettings(ExpertSetting exs)
        {
            this._myContext.ExpertSettings.Add(exs);
            return this._myContext.SaveChanges();
        }

        public int UpdateExpertSettings(ExpertSetting exs)
        {
            this._myContext.Update(exs);
            return this._myContext.SaveChanges();
        }
    }
}
