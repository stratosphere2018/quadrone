namespace Stratosphere.Quadrone
{
    /// <summary>
    /// キャラクターのアニメーションの種類
    /// </summary>
    public enum CharAnimType
    {
        /// <summary>
        /// 移動
        /// </summary>
        Move,
        /// <summary>
        /// のけぞり
        /// </summary>
        KnockBack,
        /// <summary>
        /// 通常攻撃
        /// </summary>
        Normal,
        /// <summary>
        /// チャージ攻撃
        /// </summary>
        Charge,
        /// <summary>
        /// 射撃モーション
        /// </summary>
        Shoot,
        /// <summary>
        /// 斬撃モーション
        /// </summary>
        Slash,
        /// <summary>
        /// 投擲モーション
        /// </summary>
        Throw,
        Canon = Shoot,
        Sword = Slash,
        Vulcan = Shoot,
    }
}
