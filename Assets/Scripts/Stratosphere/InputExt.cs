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
        public static bool GetButton00Press()
        { return Input.GetButtonDown(Button_00); }
        public static bool GetButton01Press()
        { return Input.GetButtonDown(Button_01); }
        public static bool GetButton02Press()
        { return Input.GetButtonDown(Button_02); }
        public static bool GetButton03Press()
        { return Input.GetButtonDown(Button_03); }
        public static bool GetButton04Press()
        { return Input.GetButtonDown(Button_04); }
        public static bool GetButton05Press()
        { return Input.GetButtonDown(Button_05); }
        public static bool GetButton06Press()
        { return Input.GetButtonDown(Button_06); }
        public static bool GetButton07Press()
        { return Input.GetButtonDown(Button_07); }
        public static bool GetButton08Press()
        { return Input.GetButtonDown(Button_08); }
        public static bool GetButton09Press()
        { return Input.GetButtonDown(Button_09); }
        public static bool GetButton10Press()
        { return Input.GetButtonDown(Button_10); }
        public static bool GetButton11Press()
        { return Input.GetButtonDown(Button_11); }
        public static bool GetButton12Press()
        { return Input.GetButtonDown(Button_12); }
        public static bool GetButton13Press()
        { return Input.GetButtonDown(Button_13); }
        public static bool GetButton14Press()
        { return Input.GetButtonDown(Button_14); }
        public static bool GetButton15Press()
        { return Input.GetButtonDown(Button_15); }
        public static bool GetButtonPress()
        {
            return GetButton00Press() | GetButton01Press() | GetButton02Press() | GetButton03Press() | GetButton04Press() | GetButton05Press() | GetButton06Press() | GetButton07Press() | GetButton08Press() | GetButton09Press() | GetButton10Press() | GetButton11Press() | GetButton12Press() | GetButton13Press() | GetButton14Press() | GetButton15Press();
        }

        #endregion

        #region ButtonDown
        public static bool GetButton00Down()
        { return Input.GetButton(Button_00); }
        public static bool GetButton01Down()
        { return Input.GetButton(Button_01); }
        public static bool GetButton02Down()
        { return Input.GetButton(Button_02); }
        public static bool GetButton03Down()
        { return Input.GetButton(Button_03); }
        public static bool GetButton04Down()
        { return Input.GetButton(Button_04); }
        public static bool GetButton05Down()
        { return Input.GetButton(Button_05); }
        public static bool GetButton06Down()
        { return Input.GetButton(Button_06); }
        public static bool GetButton07Down()
        { return Input.GetButton(Button_07); }
        public static bool GetButton08Down()
        { return Input.GetButton(Button_08); }
        public static bool GetButton09Down()
        { return Input.GetButton(Button_09); }
        public static bool GetButton10Down()
        { return Input.GetButton(Button_10); }
        public static bool GetButton11Down()
        { return Input.GetButton(Button_11); }
        public static bool GetButton12Down()
        { return Input.GetButton(Button_12); }
        public static bool GetButton13Down()
        { return Input.GetButton(Button_13); }
        public static bool GetButton14Down()
        { return Input.GetButton(Button_14); }
        public static bool GetButton15Down()
        { return Input.GetButton(Button_15); }
        public static bool GetButtonDown()
        {
            return GetButton00Down() | GetButton01Down() | GetButton02Down() | GetButton03Down() | GetButton04Down() | GetButton05Down() | GetButton06Down() | GetButton07Down() | GetButton08Down() | GetButton09Down() | GetButton10Down() | GetButton11Down() | GetButton12Down() | GetButton13Down() | GetButton14Down() | GetButton15Down();
        }

        #endregion

        #region ButtonUp
        public static bool GetButton00Up()
        { return Input.GetButtonUp(Button_00); }
        public static bool GetButton01Up()
        { return Input.GetButtonUp(Button_01); }
        public static bool GetButton02Up()
        { return Input.GetButtonUp(Button_02); }
        public static bool GetButton03Up()
        { return Input.GetButtonUp(Button_03); }
        public static bool GetButton04Up()
        { return Input.GetButtonUp(Button_04); }
        public static bool GetButton05Up()
        { return Input.GetButtonUp(Button_05); }
        public static bool GetButton06Up()
        { return Input.GetButtonUp(Button_06); }
        public static bool GetButton07Up()
        { return Input.GetButtonUp(Button_07); }
        public static bool GetButton08Up()
        { return Input.GetButtonUp(Button_08); }
        public static bool GetButton09Up()
        { return Input.GetButtonUp(Button_09); }
        public static bool GetButton10Up()
        { return Input.GetButtonUp(Button_10); }
        public static bool GetButton11Up()
        { return Input.GetButtonUp(Button_11); }
        public static bool GetButton12Up()
        { return Input.GetButtonUp(Button_12); }
        public static bool GetButton13Up()
        { return Input.GetButtonUp(Button_13); }
        public static bool GetButton14Up()
        { return Input.GetButtonUp(Button_14); }
        public static bool GetButton15Up()
        { return Input.GetButtonUp(Button_15); }
        public static bool GetButtonUp()
        {
            return GetButton00Up() | GetButton01Up() | GetButton02Up() | GetButton03Up() | GetButton04Up() | GetButton05Up() | GetButton06Up() | GetButton07Up() | GetButton08Up() | GetButton09Up() | GetButton10Up() | GetButton11Up() | GetButton12Up() | GetButton13Up() | GetButton14Up() | GetButton15Up();
        }
        #endregion

        #region Axis
        public static float GetLXAxis()
        { return Input.GetAxis(L_Stick_X); }
        public static float GetLYAxis()
        { return Input.GetAxis(L_Stick_Y); }
        public static Vector2 GetLAxis()
        { return new Vector2(GetLXAxis(), GetLYAxis()); }
        public static float GetRXAxis()
        { return Input.GetAxis(R_Stick_X); }
        public static float GetRYAxis()
        { return Input.GetAxis(R_Stick_Y); }
        public static Vector2 GetRAxis()
        { return new Vector2(GetRXAxis(), GetRYAxis()); }
        public static float GetPoVXAxis()
        { return Input.GetAxis(PoV_X); }
        public static float GetPoVYAxis()
        { return Input.GetAxis(PoV_Y); }
        public static Vector2 GetPoVAxis()
        { return new Vector2(GetPoVXAxis(), GetPoVYAxis()); }
        #endregion
    }
}
