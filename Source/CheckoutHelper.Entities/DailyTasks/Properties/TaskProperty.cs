using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutHelper.Entities.DailyTasks.Properties
{
    public class TaskProperty
    {
        // 非公開フィールド
        private PropertyType _propertyType;
        private string _name;
        private bool _allowNonSpecify;
        private string _hint;


        // 公開プロパティ

        /// <summary>
        /// プロパティの値の種類を取得します。
        /// </summary>
        public PropertyType PropertyType
        {
            get => this._propertyType;
        }

        /// <summary>
        /// プロパティの名前を取得します。
        /// </summary>
        public string Name
        {
            get => this._name;
        }

        /// <summary>
        /// 指定しないことを許可するかどうかの値を取得します。
        /// </summary>
        public bool AllowNonSpecify
        {
            get => this._allowNonSpecify;
        }

        /// <summary>
        /// ヒントを取得します。
        /// </summary>
        public string Hint
        {
            get => this._hint;
        }


        // コンストラクタ

        /// <summary>
        /// <see cref="TaskProperty"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="propertyType"></param>
        /// <param name="name"></param>
        /// <param name="allowNonSpecify"></param>
        /// <param name="hint"></param>
        public TaskProperty(PropertyType propertyType, string name, bool allowNonSpecify, string hint)
        {
            this._propertyType = propertyType;
            this._name = name;
            this._allowNonSpecify = allowNonSpecify;
            this._hint = hint;
        }
    }
}
