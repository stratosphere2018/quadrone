namespace Stratosphere.Quadrone
{
    public class Canon : Skill
    {
        Canon()
        {
            SkillName = "キャノン";
            Strength = 40;
            Description = "直線状に砲撃を放ちます。";
        }

        internal override void Effect(Character player, Character opponent)
        {
            player.Animate(CharAnimType.Canon);
        }
    }
}
