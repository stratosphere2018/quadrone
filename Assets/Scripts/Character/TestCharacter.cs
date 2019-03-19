namespace Stratosphere.Quadrone.Character
{
    public class TestCharacter : CharacterContainer
    {
        public TestCharacter()
        {
            Name = CharName.TestCharacter;
            Hp = 100;
            BusterAtk = 1;
            BusterRapid = 1;
            BusterCharge = 1;
            ChargeCount = 0;
            ChargeShot = false;
            Animate = Animation;
        }

        public int Animation(CharAnimType type)
        {
            return 1;
        }
    }
}
