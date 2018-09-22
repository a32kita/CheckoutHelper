using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutHelper.Entities
{
    /// <summary>
    /// <see cref="CheckPoint"/> のコレクション機能を提供します。
    /// </summary>
    public class CheckPointCollection : ICollection<CheckPoint>
    {
        // 非公開フィールド
        private List<CheckPoint> _items;
        private EventHandler<ItemAddedEventArgs> _itemAdded;


        // 公開プロパティ
        
        /// <summary>
        /// 現在格納されている <see cref="CheckPoint"/> の個数を取得します。
        /// </summary>
        public int Count
        {
            get => this._items.Count;
        }

        /// <summary>
        /// このコレクションが読み取り専用であるかどうかを取得します。
        /// </summary>
        public bool IsReadOnly
        {
            get => ((ICollection<CheckPoint>)_items).IsReadOnly;
        }


        // 公開イベント

        /// <summary>
        /// <see cref="CheckPoint"/> が追加されたあとに発生します。
        /// 追加された要素を確認することができます。
        /// </summary>
        public event EventHandler<ItemAddedEventArgs> ItemAdded
        {
            add => this._itemAdded += value;
            remove => this._itemAdded -= value;
        }


        // コンストラクタ

        /// <summary>
        /// 指定したコレクションから要素をコピーして、 <see cref="CheckPointCollection"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        /// <param name="collection"></param>
        public CheckPointCollection(IEnumerable<CheckPoint> collection)
        {
            this._items = new List<CheckPoint>(collection);
        }

        /// <summary>
        /// <see cref="CheckPointCollection"/> クラスの新しいインスタンスを初期化します。
        /// </summary>
        public CheckPointCollection()
            : this(new CheckPoint[0])
        {
            // 実装なし
        }

        
        // 非公開メソッド


        // 公開メソッド

        /// <summary>
        /// 末尾に <see cref="CheckPoint"/> を追加します。
        /// </summary>
        /// <param name="item"></param>
        public void Add(CheckPoint item)
        {
            this._items.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(CheckPoint item)
        {
            return ((ICollection<CheckPoint>)_items).Remove(item);
        }

        /// <summary>
        /// すべての要素を削除します。
        /// </summary>
        public void Clear()
        {
            this._items.Clear();
        }

        /// <summary>
        /// 指定した <see cref="CheckPoint"/> がコレクションに含まれているかどうかを判断します。
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Contains(CheckPoint item)
        {
            return this._items.Contains(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(CheckPoint[] array, int arrayIndex)
        {
            this._items.CopyTo(array, arrayIndex);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerator<CheckPoint> GetEnumerator()
        {
            return ((ICollection<CheckPoint>)_items).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((ICollection<CheckPoint>)_items).GetEnumerator();
        }


        // 内部クラス

        /// <summary>
        /// 
        /// </summary>
        public class ItemAddedEventArgs : EventArgs
        {
            // 公開プロパティ

            /// <summary>
            /// <see cref="CheckPoint"/> を取得または設定します。
            /// </summary>
            public CheckPoint CheckoutPoint
            {
                get;
                set;
            }


            // コンストラクタ

            /// <summary>
            /// <see cref="ItemAddedEventArgs"/> クラスのインスタンスを初期化します。
            /// </summary>
            /// <param name="checkPoint"></param>
            public ItemAddedEventArgs(CheckPoint checkPoint)
            {
                this.CheckoutPoint = checkPoint;
            }
        }
    }
}
