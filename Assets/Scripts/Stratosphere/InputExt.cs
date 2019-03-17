using UnityEngine;

namespace Stratosphere
{
    public static class InputExt
    {
        #region メンバ変数
        private const string l_Stick_X = "L Stick X";
        private const string l_Stick_Y = "L Stick Y";
        private const string r_Stick_X = "R Stick X";
        private const string r_Stick_Y = "R Stick Y";
        private const string pov_X = "PoV X";
        private const string pov_Y = "PoV Y";
        private const string button_00 = "Button 0";
        private const string button_01 = "Button 1";
        private const string button_02 = "Button 2";
        private const string button_03 = "Button 3";
        private const string button_04 = "Button 4";
        private const string button_05 = "Button 5";
        private const string button_06 = "Button 6";
        private const string button_07 = "Button 7";
        private const string button_08 = "Button 8";
        private const string button_09 = "Button 9";
        private const string button_10 = "Button 10";
        private const string button_11 = "Button 11";
        private const string button_12 = "Button 12";
        private const string button_13 = "Button 13";
        private const string button_14 = "Button 14";
        private const string button_15 = "Button 15";
        // 16ボタンで22項目
        #endregion

        #region プロパティ
        public static string L_Stick_X => l_Stick_X;
        public static string L_Stick_Y => l_Stick_Y;
        public static string R_Stick_X => r_Stick_X;
        public static string R_Stick_Y => r_Stick_Y;
        public static string PoV_Y => pov_Y;
        public static string PoV_X => pov_X;
        public static string Button_00 => button_00;
        public static string Button_01 => button_01;
        public static string Button_02 => button_02;
        public static string Button_03 => button_03;
        public static string Button_04 => button_04;
        public static string Button_05 => button_05;
        public static string Button_06 => button_06;
        public static string Button_07 => button_07;
        public static string Button_08 => button_08;
        public static string Button_09 => button_09;
        public static string Button_10 => button_10;
        public static string Button_11 => button_11;
        public static string Button_12 => button_12;
        public static string Button_13 => button_13;
        public static string Button_14 => button_14;
        public static string Button_15 => button_15;
        #endregion

        #region ButtonPress
        public static bool LXPress { get { return Input.GetButtonDown(L_Stick_X); } }
        public static bool LYPress { get { return Input.GetButtonDown(L_Stick_Y); } }
        public static bool LStickPress { get { return LXPress | LYPress; } }
        public static bool RXPress { get { return Input.GetButtonDown(R_Stick_X); } }
        public static bool RYPress { get { return Input.GetButtonDown(R_Stick_Y); } }
        public static bool RStickPress { get { return RXPress | RYPress; } }
        public static bool POVXPress { get { return Input.GetButtonDown(PoV_X); } }
        public static bool POVYPress { get { return Input.GetButtonDown(PoV_Y); } }
        public static bool POVPress { get { return POVXPress | POVYPress; } }
        public static bool Button00Press { get { return Input.GetButtonDown(Button_00); } }
        public static bool Button01Press { get { return Input.GetButtonDown(Button_01); } }
        public static bool Button02Press { get { return Input.GetButtonDown(Button_02); } }
        public static bool Button03Press { get { return Input.GetButtonDown(Button_03); } }
        public static bool Button04Press { get { return Input.GetButtonDown(Button_04); } }
        public static bool Button05Press { get { return Input.GetButtonDown(Button_05); } }
        public static bool Button06Press { get { return Input.GetButtonDown(Button_06); } }
        public static bool Button07Press { get { return Input.GetButtonDown(Button_07); } }
        public static bool Button08Press { get { return Input.GetButtonDown(Button_08); } }
        public static bool Button09Press { get { return Input.GetButtonDown(Button_09); } }
        public static bool Button10Press { get { return Input.GetButtonDown(Button_10); } }
        public static bool Button11Press { get { return Input.GetButtonDown(Button_11); } }
        public static bool Button12Press { get { return Input.GetButtonDown(Button_12); } }
        public static bool Button13Press { get { return Input.GetButtonDown(Button_13); } }
        public static bool Button14Press { get { return Input.GetButtonDown(Button_14); } }
        public static bool Button15Press { get { return Input.GetButtonDown(Button_15); } }
        public static bool ButtonPress
        {
            get
            {
                return Button00Press | Button01Press | Button02Press | Button03Press | Button04Press | Button05Press | Button06Press | Button07Press | Button08Press | Button09Press | Button10Press | Button11Press | Button12Press | Button13Press | Button14Press | Button15Press;
            }
        }
        public static bool AnyButtonPress { get { return LStickPress | RStickPress | POVPress | ButtonPress; } }
        #endregion

        #region ButtonDown
        public static bool LXDown { get { return Input.GetButton(L_Stick_X); } }
        public static bool LYDown { get { return Input.GetButton(L_Stick_Y); } }
        public static bool LStickDown { get { return LXDown | LYDown; } }
        public static bool RXDown { get { return Input.GetButton(R_Stick_X); } }
        public static bool RYDown { get { return Input.GetButton(R_Stick_Y); } }
        public static bool RStickDown { get { return RXDown | RYDown; } }
        public static bool POVXDown { get { return Input.GetButton(PoV_X); } }
        public static bool POVYDown { get { return Input.GetButton(PoV_Y); } }
        public static bool POVDown { get { return POVXDown | POVYDown; } }
        public static bool Button00Down { get { return Input.GetButton(Button_00); } }
        public static bool Button01Down { get { return Input.GetButton(Button_01); } }
        public static bool Button02Down { get { return Input.GetButton(Button_02); } }
        public static bool Button03Down { get { return Input.GetButton(Button_03); } }
        public static bool Button04Down { get { return Input.GetButton(Button_04); } }
        public static bool Button05Down { get { return Input.GetButton(Button_05); } }
        public static bool Button06Down { get { return Input.GetButton(Button_06); } }
        public static bool Button07Down { get { return Input.GetButton(Button_07); } }
        public static bool Button08Down { get { return Input.GetButton(Button_08); } }
        public static bool Button09Down { get { return Input.GetButton(Button_09); } }
        public static bool Button10Down { get { return Input.GetButton(Button_10); } }
        public static bool Button11Down { get { return Input.GetButton(Button_11); } }
        public static bool Button12Down { get { return Input.GetButton(Button_12); } }
        public static bool Button13Down { get { return Input.GetButton(Button_13); } }
        public static bool Button14Down { get { return Input.GetButton(Button_14); } }
        public static bool Button15Down { get { return Input.GetButton(Button_15); } }
        public static bool ButtonDown
        {
            get
            {
                return Button00Down | Button01Down | Button02Down | Button03Down | Button04Down | Button05Down | Button06Down | Button07Down | Button08Down | Button09Down | Button10Down | Button11Down | Button12Down | Button13Down | Button14Down | Button15Down;
            }
        }
        public static bool AnyButtonDown { get { return LStickDown | RStickDown | POVDown | ButtonDown; } }
        #endregion

        #region ButtonUp
        public static bool LXUp { get { return Input.GetButtonUp(L_Stick_X); } }
        public static bool LYUp { get { return Input.GetButtonUp(L_Stick_Y); } }
        public static bool LStickUp { get { return LXUp | LYUp; } }
        public static bool RXUp { get { return Input.GetButtonUp(R_Stick_X); } }
        public static bool RYUp { get { return Input.GetButtonUp(R_Stick_Y); } }
        public static bool RStickUp { get { return RXUp | RYUp; } }
        public static bool POVXUp { get { return Input.GetButtonUp(PoV_X); } }
        public static bool POVYUp { get { return Input.GetButtonUp(PoV_Y); } }
        public static bool POVUp { get { return POVXUp | POVYUp; } }
        public static bool Button00Up { get { return Input.GetButtonUp(Button_00); } }
        public static bool Button01Up { get { return Input.GetButtonUp(Button_01); } }
        public static bool Button02Up { get { return Input.GetButtonUp(Button_02); } }
        public static bool Button03Up { get { return Input.GetButtonUp(Button_03); } }
        public static bool Button04Up { get { return Input.GetButtonUp(Button_04); } }
        public static bool Button05Up { get { return Input.GetButtonUp(Button_05); } }
        public static bool Button06Up { get { return Input.GetButtonUp(Button_06); } }
        public static bool Button07Up { get { return Input.GetButtonUp(Button_07); } }
        public static bool Button08Up { get { return Input.GetButtonUp(Button_08); } }
        public static bool Button09Up { get { return Input.GetButtonUp(Button_09); } }
        public static bool Button10Up { get { return Input.GetButtonUp(Button_10); } }
        public static bool Button11Up { get { return Input.GetButtonUp(Button_11); } }
        public static bool Button12Up { get { return Input.GetButtonUp(Button_12); } }
        public static bool Button13Up { get { return Input.GetButtonUp(Button_13); } }
        public static bool Button14Up { get { return Input.GetButtonUp(Button_14); } }
        public static bool Button15Up { get { return Input.GetButtonUp(Button_15); } }
        public static bool ButtonUp
        {
            get
            {
                return Button00Up | Button01Up | Button02Up | Button03Up | Button04Up | Button05Up | Button06Up | Button07Up | Button08Up | Button09Up | Button10Up | Button11Up | Button12Up | Button13Up | Button14Up | Button15Up;
            }
        }
        public static bool AnyButtonUp { get { return LStickUp | RStickUp | POVUp | ButtonUp; } }
        #endregion

        #region Axis
        public static float LXAxis { get { return Input.GetAxis(L_Stick_X); } }
        public static float LYAxis { get { return Input.GetAxis(L_Stick_Y); } }
        public static Vector2 LAxis { get { return new Vector2(LXAxis, LYAxis); } }
        public static float RXAxis { get { return Input.GetAxis(R_Stick_X); } }
        public static float RYAxis { get { return Input.GetAxis(R_Stick_Y); } }
        public static Vector2 RAxis { get { return new Vector2(RXAxis, RYAxis); } }
        public static float PoVXAxis { get { return Input.GetAxis(PoV_X); } }
        public static float PoVYAxis { get { return Input.GetAxis(PoV_Y); } }
        public static Vector2 PoVAxis { get { return new Vector2(PoVXAxis, PoVYAxis); } }
        #endregion
    }
}
