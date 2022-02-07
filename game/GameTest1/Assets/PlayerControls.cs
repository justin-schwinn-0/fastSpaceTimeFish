//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""movement"",
            ""id"": ""db813d44-ec8a-4d35-9365-7f1b0ec33c42"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""145e4628-7662-4b5c-b4d1-3f483b970224"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""62608018-911f-4d0c-ae3e-fa56241e6c5f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""94583226-1832-4ed0-b282-380f7655bccd"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""959eaa93-44af-4f90-9a35-a9b0ac941334"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""timeStuff"",
            ""id"": ""cb808856-aafb-4ede-b375-f883011a3b35"",
            ""actions"": [
                {
                    ""name"": ""normal"",
                    ""type"": ""Button"",
                    ""id"": ""9b673d42-1cc7-43ac-a3cc-6304115d9120"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""slow"",
                    ""type"": ""Button"",
                    ""id"": ""f3dacfae-53e3-4a46-9d23-c065f65f5a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""stop"",
                    ""type"": ""Button"",
                    ""id"": ""7f239eb5-a999-48f6-95f5-97a09704d6b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""reverse"",
                    ""type"": ""Button"",
                    ""id"": ""5c64fbe5-efab-4a06-b16e-58a4e3d6b2cf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ced714c7-9d21-49fd-9c51-e4b4b5a996ea"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""slow"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7576962d-777c-4993-a189-73abe6514af2"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""normal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90eb4579-3008-4117-a03d-f01af503bb79"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7fcbcbbc-78a2-442c-bbeb-bdaf367647e1"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""reverse"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // movement
        m_movement = asset.FindActionMap("movement", throwIfNotFound: true);
        m_movement_move = m_movement.FindAction("move", throwIfNotFound: true);
        m_movement_jump = m_movement.FindAction("jump", throwIfNotFound: true);
        // timeStuff
        m_timeStuff = asset.FindActionMap("timeStuff", throwIfNotFound: true);
        m_timeStuff_normal = m_timeStuff.FindAction("normal", throwIfNotFound: true);
        m_timeStuff_slow = m_timeStuff.FindAction("slow", throwIfNotFound: true);
        m_timeStuff_stop = m_timeStuff.FindAction("stop", throwIfNotFound: true);
        m_timeStuff_reverse = m_timeStuff.FindAction("reverse", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // movement
    private readonly InputActionMap m_movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_movement_move;
    private readonly InputAction m_movement_jump;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_movement_move;
        public InputAction @jump => m_Wrapper.m_movement_jump;
        public InputActionMap Get() { return m_Wrapper.m_movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMove;
                @jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
            }
        }
    }
    public MovementActions @movement => new MovementActions(this);

    // timeStuff
    private readonly InputActionMap m_timeStuff;
    private ITimeStuffActions m_TimeStuffActionsCallbackInterface;
    private readonly InputAction m_timeStuff_normal;
    private readonly InputAction m_timeStuff_slow;
    private readonly InputAction m_timeStuff_stop;
    private readonly InputAction m_timeStuff_reverse;
    public struct TimeStuffActions
    {
        private @PlayerControls m_Wrapper;
        public TimeStuffActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @normal => m_Wrapper.m_timeStuff_normal;
        public InputAction @slow => m_Wrapper.m_timeStuff_slow;
        public InputAction @stop => m_Wrapper.m_timeStuff_stop;
        public InputAction @reverse => m_Wrapper.m_timeStuff_reverse;
        public InputActionMap Get() { return m_Wrapper.m_timeStuff; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TimeStuffActions set) { return set.Get(); }
        public void SetCallbacks(ITimeStuffActions instance)
        {
            if (m_Wrapper.m_TimeStuffActionsCallbackInterface != null)
            {
                @normal.started -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnNormal;
                @normal.performed -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnNormal;
                @normal.canceled -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnNormal;
                @slow.started -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnSlow;
                @slow.performed -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnSlow;
                @slow.canceled -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnSlow;
                @stop.started -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnStop;
                @stop.performed -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnStop;
                @stop.canceled -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnStop;
                @reverse.started -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnReverse;
                @reverse.performed -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnReverse;
                @reverse.canceled -= m_Wrapper.m_TimeStuffActionsCallbackInterface.OnReverse;
            }
            m_Wrapper.m_TimeStuffActionsCallbackInterface = instance;
            if (instance != null)
            {
                @normal.started += instance.OnNormal;
                @normal.performed += instance.OnNormal;
                @normal.canceled += instance.OnNormal;
                @slow.started += instance.OnSlow;
                @slow.performed += instance.OnSlow;
                @slow.canceled += instance.OnSlow;
                @stop.started += instance.OnStop;
                @stop.performed += instance.OnStop;
                @stop.canceled += instance.OnStop;
                @reverse.started += instance.OnReverse;
                @reverse.performed += instance.OnReverse;
                @reverse.canceled += instance.OnReverse;
            }
        }
    }
    public TimeStuffActions @timeStuff => new TimeStuffActions(this);
    public interface IMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface ITimeStuffActions
    {
        void OnNormal(InputAction.CallbackContext context);
        void OnSlow(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
        void OnReverse(InputAction.CallbackContext context);
    }
}
