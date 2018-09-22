using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutHelper.Entities.DailyTasks.Triggers
{
    /// <summary>
    /// <see cref="RunningTrigger"/> に実行するかどうかの判断材料を提供します。
    /// </summary>
    public class ActionHint
    {
        // 公開プロパティ

        public DateTime DateTime
        {
            get;
            set;
        }

        public bool Holiday
        {
            get;
            set;
        }
    }
}
