namespace Stratosphere.Quadrone
{
    /// <summary>
    /// カード：ソード
    /// </summary>
    public class Sword : Card
    {
        Sword()
        {
            SkillName = "ソード";
            Strength = 80;
            Description = "目の前1マスに切りつけるソードを放つ！";
        }

        internal override void Effect(Character player, Character opponent)
        {
            player.Animate(CharAnimType.Sword);
        }
    }
}
