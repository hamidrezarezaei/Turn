using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Nobatgir.Lib;

namespace Nobatgir.Model
{
    public class Turn
    {
        public Guid ID { get; set; }

        public int ExpertID { get; set; }

        [Display(Name = "تاریخ نوبت")]
        public DateTime TurnDate { get; set; }

        [Display(Name = "ساعت نوبت")]
        public string Time { get; set; }

        [Display(Name = "قیمت")]
        public long Price { get; set; }

        public TurnStatuses Status { get; set; }

        [Display(Name = "زمان انقضا")]
        public DateTime ExpireTime { get; set; }

        [Display(Name = "زمان ثبت نوبت")]
        public DateTime RegDate { get; set; }

        public Expert Expert { get; set; }

        public ICollection<TurnDetails> TurnDetails { get; set; }

        [Display(Name = "کد رهگیری")]
        public int TrackingCode { get; set; }

        [NotMapped]
        public string TurnDatePersian => persianDateTime.PersianDateStringFormat(this.TurnDate);
    }

    public enum TurnStatuses
    {
        Free = 0, Canceled = 2, Reserve = 1, Completed = 3
    }
}
