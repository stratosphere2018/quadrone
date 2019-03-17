namespace Stratosphere.Quadrone
{
    public class TestCharacter : Character
    {
        public TestCharacter()
        {
            charName = "テストキャラクター";
            hp = 100;
            Animate = Animation;
        }

        public int Animation(CharAnimType type)
        {
            return 1;
        }
    }
}
