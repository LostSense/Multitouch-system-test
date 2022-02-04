//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.2.0
//     from Assets/Buffer/TouchSystem.inputactions
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

public partial class @TouchSystem : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchSystem"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""eaec6b70-090f-4e03-98d4-b1810a808da3"",
            ""actions"": [
                {
                    ""name"": ""TouchOnePhase"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5035798f-1b2a-495e-8ee1-be53908b7a3a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchOneDelta"",
                    ""type"": ""Value"",
                    ""id"": ""d8c80200-fe28-4cf8-a0cb-cea215b9e245"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchOnePosition"",
                    ""type"": ""Value"",
                    ""id"": ""890f3953-f698-449d-af25-33b4c1304e32"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchOneStartPosition"",
                    ""type"": ""Value"",
                    ""id"": ""ebc25e57-cffa-406d-a03a-837ef4d50966"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchTwoPhase"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0f0f16f9-566f-4256-9007-e56fc99e7e2b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchTwoDelta"",
                    ""type"": ""Value"",
                    ""id"": ""c52913f7-c679-4003-a947-05cecaccf14d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchTwoPosition"",
                    ""type"": ""Value"",
                    ""id"": ""ab6f9848-525f-4356-82cd-e0bbd473b125"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchTwoStartPosition"",
                    ""type"": ""Value"",
                    ""id"": ""84038e8c-7839-4e20-a697-3209c7c2bd83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchThreePhase"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f1023966-8b2d-44e8-837c-387c2ae99077"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchThreeDelta"",
                    ""type"": ""Value"",
                    ""id"": ""1730d9f2-95e4-4d0b-b67b-9953ed383ddb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchThreePosition"",
                    ""type"": ""Value"",
                    ""id"": ""5dd8ed5c-fd9d-4e15-b42a-6147d5ab3deb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchThreeStartPosition"",
                    ""type"": ""Value"",
                    ""id"": ""9e42d6b9-70ba-4151-ac48-502e742b55af"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""BackButtonPressed"",
                    ""type"": ""Button"",
                    ""id"": ""f3289995-2ea9-4cbf-867a-e02e2f35ae37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""91fe7cf0-3aa5-473a-9d55-336d9dbe1f64"",
                    ""path"": ""<Touchscreen>/touch0/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""TouchOnePhase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16287a55-2e34-40d3-a100-586ecf6a1b76"",
                    ""path"": ""<Touchscreen>/touch0/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchOneDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fac6375-e9a5-4b94-87c2-1360facb4e88"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchOnePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ced2090-d9d5-4412-ac54-258a1a349f6c"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchTwoPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9fc0eaf-0d0e-436d-834c-3ae04f5632ea"",
                    ""path"": ""<Touchscreen>/touch0/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchOneStartPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed9f6012-b496-4286-9c4f-63e693240c53"",
                    ""path"": ""<Touchscreen>/touch1/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchTwoPhase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d31736c-c3c4-4242-bc12-4d84c0a94c50"",
                    ""path"": ""<Touchscreen>/touch1/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""TouchTwoDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9db80b0-260d-45dd-9c07-8fefdc0024d6"",
                    ""path"": ""<Touchscreen>/touch1/startPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""TouchSystem"",
                    ""action"": ""TouchTwoStartPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1f16265-6fab-4879-b4ee-8e69dd80c605"",
                    ""path"": ""<Touchscreen>/touch2/phase"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchThreePhase"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de8ad73a-9235-4b40-850a-20edc8e54b5a"",
                    ""path"": ""<Touchscreen>/touch2/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchThreeDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00e6bcdc-e0ec-4829-9c9a-d51654d3f911"",
                    ""path"": ""<Touchscreen>/touch2/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchThreePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39fd365e-4357-4ea3-9174-149a4f4e8342"",
                    ""path"": ""<Touchscreen>/touch2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchThreeStartPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c569163c-9939-41b6-9816-1d2ee6f186e3"",
                    ""path"": ""*/{Back}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BackButtonPressed"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""TouchSystem"",
            ""bindingGroup"": ""TouchSystem"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_TouchOnePhase = m_Player.FindAction("TouchOnePhase", throwIfNotFound: true);
        m_Player_TouchOneDelta = m_Player.FindAction("TouchOneDelta", throwIfNotFound: true);
        m_Player_TouchOnePosition = m_Player.FindAction("TouchOnePosition", throwIfNotFound: true);
        m_Player_TouchOneStartPosition = m_Player.FindAction("TouchOneStartPosition", throwIfNotFound: true);
        m_Player_TouchTwoPhase = m_Player.FindAction("TouchTwoPhase", throwIfNotFound: true);
        m_Player_TouchTwoDelta = m_Player.FindAction("TouchTwoDelta", throwIfNotFound: true);
        m_Player_TouchTwoPosition = m_Player.FindAction("TouchTwoPosition", throwIfNotFound: true);
        m_Player_TouchTwoStartPosition = m_Player.FindAction("TouchTwoStartPosition", throwIfNotFound: true);
        m_Player_TouchThreePhase = m_Player.FindAction("TouchThreePhase", throwIfNotFound: true);
        m_Player_TouchThreeDelta = m_Player.FindAction("TouchThreeDelta", throwIfNotFound: true);
        m_Player_TouchThreePosition = m_Player.FindAction("TouchThreePosition", throwIfNotFound: true);
        m_Player_TouchThreeStartPosition = m_Player.FindAction("TouchThreeStartPosition", throwIfNotFound: true);
        m_Player_BackButtonPressed = m_Player.FindAction("BackButtonPressed", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_TouchOnePhase;
    private readonly InputAction m_Player_TouchOneDelta;
    private readonly InputAction m_Player_TouchOnePosition;
    private readonly InputAction m_Player_TouchOneStartPosition;
    private readonly InputAction m_Player_TouchTwoPhase;
    private readonly InputAction m_Player_TouchTwoDelta;
    private readonly InputAction m_Player_TouchTwoPosition;
    private readonly InputAction m_Player_TouchTwoStartPosition;
    private readonly InputAction m_Player_TouchThreePhase;
    private readonly InputAction m_Player_TouchThreeDelta;
    private readonly InputAction m_Player_TouchThreePosition;
    private readonly InputAction m_Player_TouchThreeStartPosition;
    private readonly InputAction m_Player_BackButtonPressed;
    public struct PlayerActions
    {
        private @TouchSystem m_Wrapper;
        public PlayerActions(@TouchSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchOnePhase => m_Wrapper.m_Player_TouchOnePhase;
        public InputAction @TouchOneDelta => m_Wrapper.m_Player_TouchOneDelta;
        public InputAction @TouchOnePosition => m_Wrapper.m_Player_TouchOnePosition;
        public InputAction @TouchOneStartPosition => m_Wrapper.m_Player_TouchOneStartPosition;
        public InputAction @TouchTwoPhase => m_Wrapper.m_Player_TouchTwoPhase;
        public InputAction @TouchTwoDelta => m_Wrapper.m_Player_TouchTwoDelta;
        public InputAction @TouchTwoPosition => m_Wrapper.m_Player_TouchTwoPosition;
        public InputAction @TouchTwoStartPosition => m_Wrapper.m_Player_TouchTwoStartPosition;
        public InputAction @TouchThreePhase => m_Wrapper.m_Player_TouchThreePhase;
        public InputAction @TouchThreeDelta => m_Wrapper.m_Player_TouchThreeDelta;
        public InputAction @TouchThreePosition => m_Wrapper.m_Player_TouchThreePosition;
        public InputAction @TouchThreeStartPosition => m_Wrapper.m_Player_TouchThreeStartPosition;
        public InputAction @BackButtonPressed => m_Wrapper.m_Player_BackButtonPressed;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @TouchOnePhase.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePhase;
                @TouchOnePhase.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePhase;
                @TouchOnePhase.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePhase;
                @TouchOneDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneDelta;
                @TouchOneDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneDelta;
                @TouchOneDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneDelta;
                @TouchOnePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePosition;
                @TouchOnePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePosition;
                @TouchOnePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOnePosition;
                @TouchOneStartPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneStartPosition;
                @TouchOneStartPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneStartPosition;
                @TouchOneStartPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchOneStartPosition;
                @TouchTwoPhase.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPhase;
                @TouchTwoPhase.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPhase;
                @TouchTwoPhase.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPhase;
                @TouchTwoDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoDelta;
                @TouchTwoDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoDelta;
                @TouchTwoDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoDelta;
                @TouchTwoPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPosition;
                @TouchTwoPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPosition;
                @TouchTwoPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoPosition;
                @TouchTwoStartPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoStartPosition;
                @TouchTwoStartPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoStartPosition;
                @TouchTwoStartPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchTwoStartPosition;
                @TouchThreePhase.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePhase;
                @TouchThreePhase.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePhase;
                @TouchThreePhase.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePhase;
                @TouchThreeDelta.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeDelta;
                @TouchThreeDelta.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeDelta;
                @TouchThreeDelta.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeDelta;
                @TouchThreePosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePosition;
                @TouchThreePosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePosition;
                @TouchThreePosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreePosition;
                @TouchThreeStartPosition.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeStartPosition;
                @TouchThreeStartPosition.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeStartPosition;
                @TouchThreeStartPosition.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTouchThreeStartPosition;
                @BackButtonPressed.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackButtonPressed;
                @BackButtonPressed.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackButtonPressed;
                @BackButtonPressed.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBackButtonPressed;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TouchOnePhase.started += instance.OnTouchOnePhase;
                @TouchOnePhase.performed += instance.OnTouchOnePhase;
                @TouchOnePhase.canceled += instance.OnTouchOnePhase;
                @TouchOneDelta.started += instance.OnTouchOneDelta;
                @TouchOneDelta.performed += instance.OnTouchOneDelta;
                @TouchOneDelta.canceled += instance.OnTouchOneDelta;
                @TouchOnePosition.started += instance.OnTouchOnePosition;
                @TouchOnePosition.performed += instance.OnTouchOnePosition;
                @TouchOnePosition.canceled += instance.OnTouchOnePosition;
                @TouchOneStartPosition.started += instance.OnTouchOneStartPosition;
                @TouchOneStartPosition.performed += instance.OnTouchOneStartPosition;
                @TouchOneStartPosition.canceled += instance.OnTouchOneStartPosition;
                @TouchTwoPhase.started += instance.OnTouchTwoPhase;
                @TouchTwoPhase.performed += instance.OnTouchTwoPhase;
                @TouchTwoPhase.canceled += instance.OnTouchTwoPhase;
                @TouchTwoDelta.started += instance.OnTouchTwoDelta;
                @TouchTwoDelta.performed += instance.OnTouchTwoDelta;
                @TouchTwoDelta.canceled += instance.OnTouchTwoDelta;
                @TouchTwoPosition.started += instance.OnTouchTwoPosition;
                @TouchTwoPosition.performed += instance.OnTouchTwoPosition;
                @TouchTwoPosition.canceled += instance.OnTouchTwoPosition;
                @TouchTwoStartPosition.started += instance.OnTouchTwoStartPosition;
                @TouchTwoStartPosition.performed += instance.OnTouchTwoStartPosition;
                @TouchTwoStartPosition.canceled += instance.OnTouchTwoStartPosition;
                @TouchThreePhase.started += instance.OnTouchThreePhase;
                @TouchThreePhase.performed += instance.OnTouchThreePhase;
                @TouchThreePhase.canceled += instance.OnTouchThreePhase;
                @TouchThreeDelta.started += instance.OnTouchThreeDelta;
                @TouchThreeDelta.performed += instance.OnTouchThreeDelta;
                @TouchThreeDelta.canceled += instance.OnTouchThreeDelta;
                @TouchThreePosition.started += instance.OnTouchThreePosition;
                @TouchThreePosition.performed += instance.OnTouchThreePosition;
                @TouchThreePosition.canceled += instance.OnTouchThreePosition;
                @TouchThreeStartPosition.started += instance.OnTouchThreeStartPosition;
                @TouchThreeStartPosition.performed += instance.OnTouchThreeStartPosition;
                @TouchThreeStartPosition.canceled += instance.OnTouchThreeStartPosition;
                @BackButtonPressed.started += instance.OnBackButtonPressed;
                @BackButtonPressed.performed += instance.OnBackButtonPressed;
                @BackButtonPressed.canceled += instance.OnBackButtonPressed;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_TouchSystemSchemeIndex = -1;
    public InputControlScheme TouchSystemScheme
    {
        get
        {
            if (m_TouchSystemSchemeIndex == -1) m_TouchSystemSchemeIndex = asset.FindControlSchemeIndex("TouchSystem");
            return asset.controlSchemes[m_TouchSystemSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnTouchOnePhase(InputAction.CallbackContext context);
        void OnTouchOneDelta(InputAction.CallbackContext context);
        void OnTouchOnePosition(InputAction.CallbackContext context);
        void OnTouchOneStartPosition(InputAction.CallbackContext context);
        void OnTouchTwoPhase(InputAction.CallbackContext context);
        void OnTouchTwoDelta(InputAction.CallbackContext context);
        void OnTouchTwoPosition(InputAction.CallbackContext context);
        void OnTouchTwoStartPosition(InputAction.CallbackContext context);
        void OnTouchThreePhase(InputAction.CallbackContext context);
        void OnTouchThreeDelta(InputAction.CallbackContext context);
        void OnTouchThreePosition(InputAction.CallbackContext context);
        void OnTouchThreeStartPosition(InputAction.CallbackContext context);
        void OnBackButtonPressed(InputAction.CallbackContext context);
    }
}