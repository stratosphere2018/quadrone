namespace Stratosphere.Quadrone
{
    /// <summary>
    /// パネルの状態
    /// </summary>
    public enum PanelState
    {
        /// <summary>
        /// 通常
        /// </summary>
        Normal,
        /// <summary>
        /// 存在しない
        /// </summary>
        None,
        /// <summary>
        /// ひび割れ
        /// </summary>
        Break,
        /// <summary>
        /// 穴あき(時間で修復)
        /// </summary>
        Hole,
        /// <summary>
        /// 毒パネル
        /// </summary>
        Poison,
        /// <summary>
        /// サンクチュアリ
        /// </summary>
        Sanctuary,
    }
}
