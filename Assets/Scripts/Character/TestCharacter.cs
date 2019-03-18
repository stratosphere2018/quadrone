namespace Stratosphere.Quadrone.Character
{
    public class TestCharacter : CharacterContainer
    {
        public TestCharacter()
        {
            Name = CharName.TestCharacter;
            Hp = 100;
            Animate = Animation;
        }

        public int Animation(CharAnimType type)
        {
            return 1;
        }
    }
}
