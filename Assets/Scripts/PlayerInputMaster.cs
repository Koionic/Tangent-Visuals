// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f63bd071-8789-4dfd-a430-c055852b1a94"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c03fe879-8554-42c0-86d2-0c3f604e40e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9e9c51b0-4608-4ada-ac3d-0c3c9307156b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Value"",
                    ""id"": ""407fe634-9d90-44e8-a6a1-b8558769f379"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up/Down"",
                    ""type"": ""Button"",
                    ""id"": ""0e5cbc7b-1e7b-4eba-9332-9491efe29bbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up/Down DPad"",
                    ""type"": ""Button"",
                    ""id"": ""dd90ccb1-070e-4799-826c-cf95894f2aeb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cycle RGB"",
                    ""type"": ""Value"",
                    ""id"": ""25e64c23-e424-4069-9c73-ff04cdaf05e3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Auto Look"",
                    ""type"": ""Button"",
                    ""id"": ""a8e36c7b-1f6b-42d8-a866-10cc99bfb71b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Auto Move"",
                    ""type"": ""Button"",
                    ""id"": ""8c26bb89-a0bc-46d2-a403-4f7054dfb04c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Show Canvas"",
                    ""type"": ""Button"",
                    ""id"": ""79298798-c89c-4cf2-8d8c-21f337681c98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978bfe49-cc26-4a3d-ab7b-7d7a29327403"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c1f7a91b-d0fd-4a62-997e-7fb9b69bf235"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Triggers"",
                    ""id"": ""ab4f4ef6-a919-4d9b-8f23-0a28b90d4af4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""de03b1f9-f59b-4b93-9e7c-3d162dea5060"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""13fc820f-397b-4416-954e-5481664baf47"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""A/B"",
                    ""id"": ""a5efc6ac-2e5f-400b-ab78-dbf7b814805c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up/Down"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""40181838-7080-4017-89ca-2a0d5fee7dc6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ee01c9e3-d024-46d9-8083-517da10043c6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up/Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Bumpers"",
                    ""id"": ""22b2a299-ceda-4066-b55f-127eecac7f87"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cycle RGB"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""17fbdc58-d61d-4a16-a1f8-8dd469e968a4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cycle RGB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""de15990f-fceb-46ac-a831-b496e39c8841"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Cycle RGB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c003065d-ad63-40d7-add7-ba71552257a9"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(max=1)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up/Down DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed031728-bf5f-4b27-becd-efe0017e4b5f"",
                    ""path"": ""<Gamepad>/dpad/y"",
                    ""interactions"": """",
                    ""processors"": ""Clamp(min=-1)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Up/Down DPad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9839542e-7bd5-43f9-aabb-7dc97cfa5989"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Auto Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""38b4a9b6-90fc-4660-9d62-99b324588051"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Auto Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba205aec-e85b-4bda-85dd-f40f24b0ff37"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Show Canvas"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Roll = m_Player.FindAction("Roll", throwIfNotFound: true);
        m_Player_UpDown = m_Player.FindAction("Up/Down", throwIfNotFound: true);
        m_Player_UpDownDPad = m_Player.FindAction("Up/Down DPad", throwIfNotFound: true);
        m_Player_CycleRGB = m_Player.FindAction("Cycle RGB", throwIfNotFound: true);
        m_Player_AutoLook = m_Player.FindAction("Auto Look", throwIfNotFound: true);
        m_Player_AutoMove = m_Player.FindAction("Auto Move", throwIfNotFound: true);
        m_Player_ShowCanvas = m_Player.FindAction("Show Canvas", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Roll;
    private readonly InputAction m_Player_UpDown;
    private readonly InputAction m_Player_UpDownDPad;
    private readonly InputAction m_Player_CycleRGB;
    private readonly InputAction m_Player_AutoLook;
    private readonly InputAction m_Player_AutoMove;
    private readonly InputAction m_Player_ShowCanvas;
    public struct PlayerActions
    {
        private @PlayerInputMaster m_Wrapper;
        public PlayerActions(@PlayerInputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Roll => m_Wrapper.m_Player_Roll;
        public InputAction @UpDown => m_Wrapper.m_Player_UpDown;
        public InputAction @UpDownDPad => m_Wrapper.m_Player_UpDownDPad;
        public InputAction @CycleRGB => m_Wrapper.m_Player_CycleRGB;
        public InputAction @AutoLook => m_Wrapper.m_Player_AutoLook;
        public InputAction @AutoMove => m_Wrapper.m_Player_AutoMove;
        public InputAction @ShowCanvas => m_Wrapper.m_Player_ShowCanvas;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Roll.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRoll;
                @UpDown.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDown.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDown;
                @UpDownDPad.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDownDPad;
                @UpDownDPad.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDownDPad;
                @UpDownDPad.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnUpDownDPad;
                @CycleRGB.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleRGB;
                @CycleRGB.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleRGB;
                @CycleRGB.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCycleRGB;
                @AutoLook.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoLook;
                @AutoLook.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoLook;
                @AutoLook.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoLook;
                @AutoMove.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoMove;
                @AutoMove.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoMove;
                @AutoMove.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAutoMove;
                @ShowCanvas.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowCanvas;
                @ShowCanvas.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowCanvas;
                @ShowCanvas.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowCanvas;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @UpDown.started += instance.OnUpDown;
                @UpDown.performed += instance.OnUpDown;
                @UpDown.canceled += instance.OnUpDown;
                @UpDownDPad.started += instance.OnUpDownDPad;
                @UpDownDPad.performed += instance.OnUpDownDPad;
                @UpDownDPad.canceled += instance.OnUpDownDPad;
                @CycleRGB.started += instance.OnCycleRGB;
                @CycleRGB.performed += instance.OnCycleRGB;
                @CycleRGB.canceled += instance.OnCycleRGB;
                @AutoLook.started += instance.OnAutoLook;
                @AutoLook.performed += instance.OnAutoLook;
                @AutoLook.canceled += instance.OnAutoLook;
                @AutoMove.started += instance.OnAutoMove;
                @AutoMove.performed += instance.OnAutoMove;
                @AutoMove.canceled += instance.OnAutoMove;
                @ShowCanvas.started += instance.OnShowCanvas;
                @ShowCanvas.performed += instance.OnShowCanvas;
                @ShowCanvas.canceled += instance.OnShowCanvas;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
        void OnUpDown(InputAction.CallbackContext context);
        void OnUpDownDPad(InputAction.CallbackContext context);
        void OnCycleRGB(InputAction.CallbackContext context);
        void OnAutoLook(InputAction.CallbackContext context);
        void OnAutoMove(InputAction.CallbackContext context);
        void OnShowCanvas(InputAction.CallbackContext context);
    }
}
