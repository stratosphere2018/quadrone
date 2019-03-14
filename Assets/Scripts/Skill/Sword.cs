namespace Stratosphere.Quadrone
{
    public class Sword : Skill
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
