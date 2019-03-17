using UnityEngine;

namespace BeginIt {
    public static class InputButtonDown {
        // 1. Button down properties.
        //public static bool example { get { return IsButtonDown(exampleButton); } }

        // 2. Button down repeatedly properties. (Optional)
        //public static bool exampleRepeat { get { return IsButtonDown(exampleButton, true); } }
        public static bool upRepeat { get { return IsButtonDown(upButton, true); } }
        public static bool downRepeat { get { return IsButtonDown(downButton, true); } }
        public static bool leftRepeat { get { return IsButtonDown(leftButton, true); } }
        public static bool rightRepeat { get { return IsButtonDown(rightButton, true); } }

        class Button {
            public string axis;
            public bool isNegative;
            public bool isPressed;
            public float nextTime;

            public Button(string axis) {
                this.axis = axis;
            }

            public Button(string axis, bool isNegative) {
                this.axis = axis;
                this.isNegative = isNegative;
            }
        }
        // 3. Button objects. Set axis name and is negative here.
        //static Button exampleButton = new Button("Example");
        static Button upButton = new Button("Vertical");
        static Button downButton = new Button("Vertical", true);
        static Button leftButton = new Button("Horizontal", true);
        static Button rightButton = new Button("Horizontal");

        // 4. Repeat threshold and speed.
        static float threshold = 0.3f;
        static float speed = threshold;

        static bool IsButtonDown(Button button) {
            return IsButtonDown(button, false);
        }

        static bool IsButtonDown(Button button, bool isRepeatedly) {
            if ((button.isNegative && Input.GetAxisRaw(button.axis) < 0f)
                || (!button.isNegative && Input.GetAxisRaw(button.axis) > 0f)) {

                if ((isRepeatedly && Time.unscaledTime > button.nextTime)
                    || (!isRepeatedly && !button.isPressed)) {

                    if (isRepeatedly) button.nextTime = Time.unscaledTime + (button.isPressed ? speed : threshold);
                    button.isPressed = true;
                    return true;
                }
            } else {
                if (isRepeatedly) button.nextTime = 0f;
                button.isPressed = false;
            }
            return false;
        }
    }
}
