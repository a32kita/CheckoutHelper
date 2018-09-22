using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutHelper.Entities
{
    /// <summary>
    /// チェックポイントを記録します。
    /// </summary>
    public class CheckPoint
    {
        // 非公開フィールド
        private DateTime _dateTime;
        private string _comment;


        // 公開プロパティ

        /// <summary>
        /// 時刻を取得または設定します。
        /// </summary>
        public DateTime DateTime
        {
            get => this._dateTime;
            set => this._dateTime = value;
        }

        /// <summary>
        /// コメントを取得または設定します。
        /// </summary>
        public string Comment
        {
            get => this._comment;
            set => this._comment = value;
        }

        /// <summary>
        /// 時間を取得します。
        /// </summary>
        public int Hour
        {
            get => this._dateTime.Hour;
        }

        /// <summary>
        /// 分を取得します。
        /// </summary>
        public int Minute
        {
            get => this._dateTime.Minute;
        }

        /// <summary>
        /// 病を取得します。
        /// </summary>
        public int Second
        {
            get => this._dateTime.Second;
        }


        // コンストラクタ
        
        /// <summary>
        /// 時刻とコメントを指定して、　<see cref="CheckPoint"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="dateTime"></param>
        /// <param name="comment"></param>
        public CheckPoint(DateTime dateTime, string comment)
        {
            this._dateTime = dateTime;
            this._comment = comment;
        }


        // 公開静的メソッド

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comment"></param>
        /// <returns></returns>
        public static CheckPoint CreateNow(string comment)
        {
            return new CheckPoint(DateTime.Now, comment);
        }
    }
}
