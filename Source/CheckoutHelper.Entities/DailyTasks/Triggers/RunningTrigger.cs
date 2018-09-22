using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CheckoutHelper.Entities.DailyTasks.Properties;

namespace CheckoutHelper.Entities.DailyTasks.Triggers
{
    public class RunningTrigger : IPropertiesEnabled
    {
        // 非公開フィールド
        private Dictionary<TaskProperty, Object> _properties;


        // 公開プロパティ

        /// <summary>
        /// プロパティと設定値の一覧を取得します。
        /// </summary>
        public IDictionary<TaskProperty, Object> Properties
        {
            get => this._properties;
        }


        // コンストラクタ

        /// <summary>
        /// <see cref="RunningTrigger"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        public RunningTrigger()
        {
            this._properties = new Dictionary<TaskProperty, Object>();

            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "実行タイミング", false, "退勤時刻の何分前に実行するかを設定します。"), 0);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "日曜日", true, "日曜日に実行するかどうかを設定します。"), false);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "月曜日", true, "月曜日に実行するかどうかを設定します。"), true);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "火曜日", true, "火曜日に実行するかどうかを設定します。"), true);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "水曜日", true, "水曜日に実行するかどうかを設定します。"), true);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "木曜日", true, "木曜日に実行するかどうかを設定します。"), true);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "金曜日", true, "金曜日に実行するかどうかを設定します。"), true);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "土曜日", true, "土曜日に実行するかどうかを設定します。"), false);
            this._properties.Add(
                new TaskProperty(PropertyType.Integer, "祝日", true, "祝日に実行するかどうかを設定します。"), false);
        }


        // 公開メソッド

        /// <summary>
        /// 現在のプロパティと <see cref="ActionHint"/> を参照し、実行タイミングであるかどうかを判断します。
        /// </summary>
        /// <param name="hint"></param>
        /// <returns></returns>
        public bool CheckTriggerApplicable(ActionHint hint)
        {

        }
    }
}
