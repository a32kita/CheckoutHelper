using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CheckoutHelper.Entities.DailyTasks.Properties;

namespace CheckoutHelper.Entities.DailyTasks
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class DailyTaskBase : IPropertiesEnabled
    {
        // 非公開フィールド
        private string _name;
        private Dictionary<TaskProperty, Object> _properties;



        // 公開プロパティ

        public string Name
        {
            get => this._name;
            protected set => this._name = value;
        }

        public IDictionary<TaskProperty, Object> Properties
        {
            get => this._properties;
        }


        // コンストラクタ

        /// <summary>
        /// 
        /// </summary>
        public DailyTaskBase()
        {
            this._name = "Untitled Action";
            this._properties = new Dictionary<TaskProperty, Object>();
        }
    }
}
