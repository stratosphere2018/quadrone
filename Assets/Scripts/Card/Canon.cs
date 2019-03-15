namespace Stratosphere.Quadrone
{
    /// <summary>
    /// カード：キャノン
    /// </summary>
    public class Canon : Card
    {
        Canon()
        {
            SkillName = "キャノン";
            Strength = 40;
            Description = "直線状に砲撃を放ちます。";
        }

        /// <summary>
        /// 使用時の効果
        /// </summary>
        /// <param name="executioner">使用したプレイヤー</param>
        /// <param name="opponent">相手側</param>
        internal override void Effect(Character executioner, Character opponent)
        {
            executioner.Animate(CharAnimType.Canon);
        }
    }
}
