namespace Stratosphere.Quadrone.Character
{
    public class TestCharacter : CharacterContainer
    {
        public TestCharacter()
        {
            CharName = "テストキャラクター";
            Hp = 100;
            Animate = Animation;
        }

        public int Animation(CharAnimType type)
        {
            return 1;
        }
    }
}
