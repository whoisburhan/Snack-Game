// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/PlayerAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAction"",
    ""maps"": [
        {
            ""name"": ""Snack"",
            ""id"": ""de06e5cb-41b6-4cd0-87e4-18707f063071"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e22bf7ac-6287-48c1-b847-71aa10cca776"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""36dcc435-db38-4241-9948-13c62d57976a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""b02fd19f-4bc6-46c1-af0a-314d68aece0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""457a0465-0322-46a8-94b0-21239205e144"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""6c836182-f78d-4687-b91f-6a1733720e1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""66368337-8c10-48b9-9f6f-4fff1693e4ec"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""cd48dafa-16fb-4d9d-bf6b-966eb883f55f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3f6606b1-9aa9-4eea-b807-3372473c9601"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""50470ea0-03ba-47fe-95cc-e524085f3877"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""944d700c-c951-4a3b-adb6-dadb52d32840"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""39530ff9-f28a-457f-a8d9-7d7c76dbddfe"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""ed039f44-37ba-438e-96c9-8b2d0963b490"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3abce8a3-11d7-4be5-815e-b7bbc8479cc8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6cd77dca-895c-4b58-b1e8-968f7aec3262"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0dc46f65-d326-4a0e-9ee9-4ae6614302d4"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c3b42d37-fb5b-4411-bfad-736a2cdc97d6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""77237bc9-55fd-4eaa-865c-d0c270a2f67d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f96d7621-acb6-4fa7-a1b6-f8db8acf9ebe"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6aaa9d44-e3db-40ed-8242-e4eaf9b49edf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""875f9cb5-0811-41f5-98f6-87ebdc15452f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a137a846-5cf3-450e-81d2-1d395987349c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b0b3f93-3899-42dd-afaf-cdd9b58c4321"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3dd38b5-744e-4eec-9218-a964d3e14387"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b6335f-1beb-4da2-babd-3d86922df8c4"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Snack
        m_Snack = asset.FindActionMap("Snack", throwIfNotFound: true);
        m_Snack_Movement = m_Snack.FindAction("Movement", throwIfNotFound: true);
        m_Snack_Up = m_Snack.FindAction("Up", throwIfNotFound: true);
        m_Snack_Down = m_Snack.FindAction("Down", throwIfNotFound: true);
        m_Snack_Left = m_Snack.FindAction("Left", throwIfNotFound: true);
        m_Snack_Right = m_Snack.FindAction("Right", throwIfNotFound: true);
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

    // Snack
    private readonly InputActionMap m_Snack;
    private ISnackActions m_SnackActionsCallbackInterface;
    private readonly InputAction m_Snack_Movement;
    private readonly InputAction m_Snack_Up;
    private readonly InputAction m_Snack_Down;
    private readonly InputAction m_Snack_Left;
    private readonly InputAction m_Snack_Right;
    public struct SnackActions
    {
        private @PlayerAction m_Wrapper;
        public SnackActions(@PlayerAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Snack_Movement;
        public InputAction @Up => m_Wrapper.m_Snack_Up;
        public InputAction @Down => m_Wrapper.m_Snack_Down;
        public InputAction @Left => m_Wrapper.m_Snack_Left;
        public InputAction @Right => m_Wrapper.m_Snack_Right;
        public InputActionMap Get() { return m_Wrapper.m_Snack; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SnackActions set) { return set.Get(); }
        public void SetCallbacks(ISnackActions instance)
        {
            if (m_Wrapper.m_SnackActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_SnackActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_SnackActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_SnackActionsCallbackInterface.OnMovement;
                @Up.started -= m_Wrapper.m_SnackActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_SnackActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_SnackActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_SnackActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_SnackActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_SnackActionsCallbackInterface.OnDown;
                @Left.started -= m_Wrapper.m_SnackActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_SnackActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_SnackActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_SnackActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_SnackActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_SnackActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_SnackActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public SnackActions @Snack => new SnackActions(this);
    public interface ISnackActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
}
