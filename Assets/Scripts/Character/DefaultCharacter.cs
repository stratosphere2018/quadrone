namespace Stratosphere.Quadrone
{
    /// <summary>
    /// テスト用のデフォルトキャラクター
    /// </summary>
    public class DefaultCharacter : Character
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        DefaultCharacter()
        {
            CharName = "テストキャラクター";
        }

        /// <summary>
        /// キャラクターをアニメーションさせる
        /// </summary>
        /// <param name="type">アニメーションの種類</param>
        public override void Animate(CharAnimType type)
        {

        }
    }
}
