using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutHelper.Entities
{
    /// <summary>
    /// 出勤日を表します。
    /// </summary>
    public class WorkingDay
    {
        // 非公開フィールド
        private CheckPointCollection _checkPoints;
        private DateTime? _date;

        
        // 公開プロパティ

        /// <summary>
        /// チェックポイントの一覧を取得します。
        /// </summary>
        public CheckPointCollection CheckPoints
        {
            get => this._checkPoints;
        }


        // コンストラクタ

        /// <summary>
        /// <see cref="WorkingDay"/> クラスのインスタンスを初期化します。
        /// </summary>
        public WorkingDay()
        {
            this._checkPoints = new CheckPointCollection();
            this._checkPoints.ItemAdded += _checkPoints_ItemAdded;

            this._date = null;
        }

        
        // 非公開メソッド

        private void _checkPoints_ItemAdded(object sender, CheckPointCollection.ItemAddedEventArgs e)
        {
            if (this._date == null)
            {
                this._date = e.CheckoutPoint.DateTime;
                return;
            }

            if (this._date != e.CheckoutPoint.DateTime)
                throw new ArgumentException("別の日付のチェックポイントが追加されました。");
        }
    }
}
