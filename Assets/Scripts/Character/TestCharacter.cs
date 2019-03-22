namespace Stratosphere.Quadrone.Character
{
    public class TestCharacter : CharacterContainer
    {
        public TestCharacter()
        {
            Name = CharName.TestCharacter;
            Hp = 100;
            BusterAtkPower = 1;
            BusterRapidPower = 1;
            BusterChargePower = 1;
            ChargeCount = 0;
            ChargeShotFlag = false;
            Animate = Animation;
        }

        public int Animation(CharAnimType type)
        {
            return 1;
        }
    }
}
