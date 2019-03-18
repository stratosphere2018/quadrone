namespace Stratosphere.Quadrone.Card
{
    /// <summary>
    /// カード：ソード
    /// </summary>
    public class Sword : CardContainer
    {
        Sword()
        {
            SkillName = "ソード";
            Strength = 80;
            Description = "目の前1マスに切りつけるソードを放つ！";
        }

        internal override void Effect(CharacterContainer player, CharacterContainer opponent)
        {
            player.Animate(CharAnimType.Sword);
        }
    }
}
