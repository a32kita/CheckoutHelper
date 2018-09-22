using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CheckoutHelper.Entities.DailyTasks.Properties;

namespace CheckoutHelper.Entities.DailyTasks
{
    public interface IPropertiesEnabled
    {
        IDictionary<TaskProperty, Object> Properties
        {
            get;
        }
    }
}
