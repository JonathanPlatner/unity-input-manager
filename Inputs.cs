using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inputs
{
    [System.Serializable]
    public class Button
    {
        public enum MouseButton { None = -1, Zero, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
        [SerializeField]
        private KeyCode key;
        [SerializeField]
        private MouseButton mouseButton = MouseButton.None;
        [SerializeField]
        private string gamepadButton;

        public Button(MouseButton mb, KeyCode k, string gp)
        {
            mouseButton = mb;
            key = k;
            gamepadButton = gp;
        }

        /// <summary>
        /// key, mouse button, or gamepad buton is currently pressed
        /// </summary>
        public bool Active()
        {
            if(key != KeyCode.None)
            {
                if(Input.GetKey(key)) return true;
            }
            if(mouseButton != MouseButton.None)
            {
                if(Input.GetMouseButton((int)mouseButton)) return true;
            }
            if(gamepadButton != string.Empty)
            {
                if(Input.GetButton(gamepadButton)) return true;
            }
            return false;
        }

        /// <summary>
        /// Rising edge trigger (pressed) for the given key, mouse button, or gamepad button
        /// </summary>
        public bool Down()
        {
            if(key != KeyCode.None)
            {
                if(Input.GetKeyDown(key)) return true;
            }
            if(mouseButton != MouseButton.None)
            {
                if(Input.GetMouseButtonDown((int)mouseButton)) return true;
            }
            if(gamepadButton != string.Empty)
            {
                if(Input.GetButtonDown(gamepadButton)) return true;
            }
            return false;
        }

        /// <summary>
        /// Falling edge trigger (released) for the given key, mouse button, or gamepad button
        /// </summary>
        public bool Up()
        {
            if(key != KeyCode.None)
            {
                if(Input.GetKeyUp(key)) return true;
            }
            if(mouseButton != MouseButton.None)
            {
                if(Input.GetMouseButtonUp((int)mouseButton)) return true;
            }
            if(gamepadButton != string.Empty)
            {
                if(Input.GetButtonUp(gamepadButton)) return true;
            }
            return false;
        }
    }

    [System.Serializable]
    public class Axis
    {
        [SerializeField]
        private KeyCode positive;
        [SerializeField]
        private KeyCode negative;
        [SerializeField]
        private string gamepadAxis;

        public Axis(KeyCode p, KeyCode n, string gp)
        {
            positive = p;
            negative = n;
            gamepadAxis = gp;
        }

        public float Value()
        {
            float value = 0;

            if(gamepadAxis != string.Empty) return Input.GetAxis(gamepadAxis);

            if(positive != KeyCode.None)
            {
                if(Input.GetKey(positive)) value += 1;
            }

            if(negative != KeyCode.None)
            {
                if(Input.GetKey(negative)) value -= 1;
            }
            return value;
        }

    }
}
