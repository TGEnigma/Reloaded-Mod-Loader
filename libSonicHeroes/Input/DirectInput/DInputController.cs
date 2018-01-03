﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDX.DirectInput;
using SonicHeroes.Input;
using static SonicHeroes.Input.ControllerCommon;
using static SonicHeroes.Input.DirectInput.DInputCommon;

namespace SonicHeroes.Input.DirectInput
{
    /// <summary>
    /// Provides functionality for obtaining input from a DirectInput controller within the mod loader.
    /// Extended to allow for keyboard functionality.
    /// </summary>
    public class DInputController : Joystick, IController
    {
        /// <summary>
        /// Store the individual button mappings structure for this controller.
        /// </summary>
        public Controller_Button_Mapping ButtonMapping { get; set; }

        /// <summary>
        /// Store the individual axis mappings structure for this controller.
        /// </summary>
        public Controller_Axis_Mapping AxisMapping { get; set; }

        /// <summary>
        /// Defines the custom botton mapping which simulates the individual axis and analog inputs.
        /// </summary>
        public Emulation_Button_Mapping EmulationMapping { get; set; }

        /// <summary>
        /// Defines the individual port used for this specific controller.
        /// </summary>
        public int ControllerID { get; set; }

        /// <summary>
        /// Defines the current state of the DirectInput controller such as the pressed buttons, etc.
        /// </summary>
        public JoystickState JoystickState { get; set; }

        /// <summary>
        /// Provides a control scheme remapper allowing for buttons to be remapped on the fly.
        /// </summary>
        public Remapper Remapper { get; set; }

        /// <summary>
        /// Constructor for this class, defines the individual controller.
        /// </summary>
        public DInputController(SharpDX.DirectInput.DirectInput directInput, Guid deviceGuid) : base(directInput, deviceGuid)
        {
            // Instantiate the remapper.
            Remapper = new Remapper(Remapper.InputDeviceType.DirectInput, this);

            // Get the controller key binding.
            Remapper.GetMappings();
        }

        /// <summary>
        /// Updates the current state of the controller in question, retrieving the current button presses
        /// and axis measurements.
        /// </summary>
        public void UpdateControllerState()
        {
            JoystickState = this.GetCurrentState();
        }

        /// <summary>
        /// Waits for the user to move an axis and retrieves the last pressed axis. 
        /// Accepts any axis as input. Returns the read-in axis.
        /// </summary>
        /// <param name="timeoutSeconds">The timeout in seconds for the controller assignment.</param>
        /// <param name="currentTimeout">The current amount of time left in seconds, use this to update the GUI.</param>
        /// <param name="mappingEntry">Specififies the mapping entry containing the axis to be remapped.</param>
        public void Remap_Axis(int timeoutSeconds, out float currentTimeout, Controller_Axis_Mapping_Entry mappingEntry) { Remapper.Remap_Axis(timeoutSeconds, out currentTimeout, mappingEntry); }

        /// <summary>
        /// Waits for the user to press a button and retrieves the last pressed button. 
        /// Accepts any axis as input. Returns the read-in axis.
        /// </summary>
        /// <param name="timeoutSeconds">The timeout in seconds for the controller assignment.</param>
        /// <param name="currentTimeout">The current amount of time left in seconds, use this to update the GUI.</param>
        /// <param name="buttonToMap">Specififies the button variable where the index of the pressed button will be written to. Either a member of Controller_Button_Mapping or Emulation_Button_Mapping</param>
        public void Remap_Buttons(int timeoutSeconds, out float currentTimeout, ref byte buttonToMap) { Remapper.Remap_Buttons(timeoutSeconds, out currentTimeout, ref buttonToMap); }

        /// <summary>
        /// Retrieves whether a specific button is pressed or not. 
        /// Accepts an enum of Controller_Buttons_Generic as parameter and returns the button ID mapped to
        /// the requested Controller_Buttons_Generic member of the "emulated" 360 pad.
        /// True if said button is pressed, else false.
        /// </summary>
        public bool GetButtonState(Controller_Buttons_Generic button)
        {
            // Retrieve requested button index.
            int buttonIndex = DInput_GetMappedButtonIndex(button, ButtonMapping);

            // Return the state declaring if the joystick button is pressed.
            return JoystickState.Buttons[buttonIndex];
        }

        /// <summary>
        /// Retrieves the specific intensity in terms of how far/deep an axis is pressed in.
        /// The return value should be a floating point number between -100 and 100 float.
        /// For triggers, the range is a value between 0 and 100.
        /// </summary>
        public float GetAxisState(Controller_Axis_Generic axis)
        {
            // Retrieve requested axis mapping entry.
            Controller_Axis_Mapping_Entry controllerAxisMapping = DInput_GetMappedAxis(axis, AxisMapping);

            // Retrieve the intensity of the axis press-in value.
            return DInput_GetAxisValue(controllerAxisMapping, JoystickState);
        }

        /// <summary>
        /// Retrieves all of the individual button states as an array of boolean values.
        /// True if a button is pressed, false if a button is not pressed.
        /// Note: The current controller state must first be manually updated.
        /// </summary>
        /// <returns></returns>
        public bool[] GetButtons()
        {
            return JoystickState.Buttons;
        }

        /// <summary>
        /// Retrieves the state of all of the axis and buttons of the controller as well as the DPAD state
        /// and retrieves it in a struct format convenient for the modder's use.
        /// </summary>
        /// <returns>Controller inputs as a custom struct.</returns>
        public Controller_Inputs GetControllerState()
        {
            // Update the current state of the Joystick/Controller
            JoystickState = this.GetCurrentState();

            // Instantiate an instance of controller inputs.
            Controller_Inputs controllerInputs = new Controller_Inputs();

            // Retrieve all of the buttons;
            controllerInputs = GetControllerState_Buttons(controllerInputs);

            // Retrieve all of the axis.
            controllerInputs = GetControllerState_Axis(controllerInputs);

            // Retrieve DPAD Information
            if (JoystickState.PointOfViewControllers[0] == -1) { }
            else
            {
                switch ((DPAD_Direction)JoystickState.PointOfViewControllers[0])
                {
                    case DPAD_Direction.UP: controllerInputs.controllerButtons.DPAD_UP = true; break;
                    case DPAD_Direction.DOWN: controllerInputs.controllerButtons.DPAD_DOWN = true; break;
                    case DPAD_Direction.LEFT: controllerInputs.controllerButtons.DPAD_LEFT = true; break;
                    case DPAD_Direction.RIGHT: controllerInputs.controllerButtons.DPAD_RIGHT = true; break;
                    case DPAD_Direction.UP_LEFT: controllerInputs.controllerButtons.DPAD_UP = true; controllerInputs.controllerButtons.DPAD_LEFT = true; break;
                    case DPAD_Direction.UP_RIGHT: controllerInputs.controllerButtons.DPAD_UP = true; controllerInputs.controllerButtons.DPAD_RIGHT = true; break;
                    case DPAD_Direction.DOWN_LEFT: controllerInputs.controllerButtons.DPAD_DOWN = true; controllerInputs.controllerButtons.DPAD_LEFT = true; break; 
                    case DPAD_Direction.DOWN_RIGHT: controllerInputs.controllerButtons.DPAD_DOWN = true; controllerInputs.controllerButtons.DPAD_RIGHT = true; break;
                }
            }

            // Retrieve Emulated Keys
            controllerInputs = GetControllerState_EmulatedKeys(controllerInputs);

            // Return to base.
            return controllerInputs;
        }

        /// <summary>
        /// Retrieves and returns the state of all of the controller's individual buttons.
        /// </summary>
        /// <param name="controllerInputs">The controller input struct.</param>
        private Controller_Inputs GetControllerState_Buttons(Controller_Inputs controllerInputs)
        {
            // Retrieve all of the buttons.
            controllerInputs.controllerButtons.Button_A = GetButtonState(Controller_Buttons_Generic.Button_A);
            controllerInputs.controllerButtons.Button_B = GetButtonState(Controller_Buttons_Generic.Button_B);
            controllerInputs.controllerButtons.Button_X = GetButtonState(Controller_Buttons_Generic.Button_X);
            controllerInputs.controllerButtons.Button_Y = GetButtonState(Controller_Buttons_Generic.Button_Y);

            controllerInputs.controllerButtons.Button_LB = GetButtonState(Controller_Buttons_Generic.Button_LB);
            controllerInputs.controllerButtons.Button_RB = GetButtonState(Controller_Buttons_Generic.Button_RB);

            controllerInputs.controllerButtons.Button_Back = GetButtonState(Controller_Buttons_Generic.Button_Back);
            controllerInputs.controllerButtons.Button_Guide = GetButtonState(Controller_Buttons_Generic.Button_Guide);
            controllerInputs.controllerButtons.Button_Start = GetButtonState(Controller_Buttons_Generic.Button_Start);

            // Return the buttons.
            return controllerInputs;
        }

        /// <summary>
        /// Retrieves and returns the state of all of the controller's individual buttons.
        /// </summary>
        /// <param name="controllerInputs">The controller input struct.</param>
        private Controller_Inputs GetControllerState_Axis(Controller_Inputs controllerInputs)
        {
            // Retrieve all of the axis.
            controllerInputs.SetLeftTriggerPressure(GetAxisState(Controller_Axis_Generic.Left_Trigger_Pressure));
            controllerInputs.SetRightTriggerPressure(GetAxisState(Controller_Axis_Generic.Right_Trigger_Pressure));

            controllerInputs.leftStick.SetX(GetAxisState(Controller_Axis_Generic.Left_Stick_X));
            controllerInputs.leftStick.SetY(GetAxisState(Controller_Axis_Generic.Left_Stick_Y));

            controllerInputs.rightStick.SetX(GetAxisState(Controller_Axis_Generic.Right_Stick_X));
            controllerInputs.rightStick.SetY(GetAxisState(Controller_Axis_Generic.Right_Stick_Y));

            // Return the axis.
            return controllerInputs;
        }

        /// <summary>
        /// Retrieves and returns the state of all of the inputs that are emulated on a digital (keyboard)
        /// to analog basis to allow the use of e.g. analog sticks within keyboards.
        /// If a non-zero value is set and the button is not pressed, the original value will not be overwritten.
        /// (i.e. Only overrides if input is sent)
        /// </summary>
        /// <returns></returns>
        private Controller_Inputs GetControllerState_EmulatedKeys(Controller_Inputs controllerInputs)
        {
            // Retrieve Emulated DPAD Keys
            #region DPAD Keys
            if (EmulationMapping.DPAD_DOWN != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.DPAD_DOWN, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If it is pressed, override the current value to include the flag.
                if (isPressed) { controllerInputs.controllerButtons.DPAD_DOWN = true; }
            }
            if (EmulationMapping.DPAD_LEFT != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.DPAD_LEFT, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If it is pressed, override the current value to include the flag.
                if (isPressed) { controllerInputs.controllerButtons.DPAD_LEFT = true; }
            }
            if (EmulationMapping.DPAD_RIGHT != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.DPAD_RIGHT, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If it is pressed, override the current value to include the flag.
                if (isPressed) { controllerInputs.controllerButtons.DPAD_RIGHT = true; }
            }
            if (EmulationMapping.DPAD_UP != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.DPAD_UP, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If it is pressed, override the current value to include the flag.
                if (isPressed) { controllerInputs.controllerButtons.DPAD_UP = true; }
            }
            #endregion

            // Retrieve Emulated Left Analog Stick
            #region Left Analog Stick
            if (EmulationMapping.Left_Stick_Down != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Left_Stick_Down, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.leftStick.GetY() + DInputManager.AXIS_MAX_VALUE_F); }
            }

            if (EmulationMapping.Left_Stick_Left != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Left_Stick_Left, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.leftStick.GetX() + DInputManager.AXIS_MIN_VALUE_F); }
            }

            if (EmulationMapping.Left_Stick_Right != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Left_Stick_Right, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.leftStick.GetX() + DInputManager.AXIS_MAX_VALUE_F); }
            }

            if (EmulationMapping.Left_Stick_Up != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Left_Stick_Up, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.leftStick.GetY() + DInputManager.AXIS_MIN_VALUE_F); }
            }
            #endregion

            // Retrieve Emulated Right Analog Stick
            #region Right Analog Stick
            if (EmulationMapping.Right_Stick_Down != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Right_Stick_Down, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.rightStick.GetY() + DInputManager.AXIS_MAX_VALUE_F); }
            }

            if (EmulationMapping.Right_Stick_Left != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Right_Stick_Left, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.rightStick.GetX() + DInputManager.AXIS_MIN_VALUE_F); }
            }

            if (EmulationMapping.Right_Stick_Right != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Right_Stick_Right, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.rightStick.GetX() + DInputManager.AXIS_MAX_VALUE_F); }
            }

            if (EmulationMapping.Right_Stick_Up != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Right_Stick_Up, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.leftStick.SetX(controllerInputs.rightStick.GetY() + DInputManager.AXIS_MIN_VALUE_F); }
            }
            #endregion

            // Retrieve Emulated Triggers
            #region Triggers
            if (EmulationMapping.Right_Trigger != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Right_Trigger, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.SetRightTriggerPressure(DInputManager.AXIS_MAX_VALUE_F * DInputManager.TRIGGER_SCALE_FACTOR); }
            }

            if (EmulationMapping.Left_Trigger != BUTTON_NULL)
            {
                // Retrieve the button index for the emulated button.
                int buttonIndex = DInput_GetEmulatedButtonIndex(Emulated_Buttons_Generic.Left_Trigger, EmulationMapping);

                // Check if button is pressed.
                bool isPressed = JoystickState.Buttons[buttonIndex];

                // If the stick value is not 0 and is not pressed, do not override.
                if (isPressed)
                { controllerInputs.SetLeftTriggerPressure(DInputManager.AXIS_MAX_VALUE_F / DInputManager.TRIGGER_SCALE_FACTOR); }
            }
            #endregion

            // Return controller inputs
            return controllerInputs;
        }
    }
}
