//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Player/Scripts/MoveController/InputSettings/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerMainMap"",
            ""id"": ""3c980aac-e3bf-4cfa-8697-ea1782f0db2e"",
            ""actions"": [
                {
                    ""name"": ""WASD_Move"",
                    ""type"": ""Value"",
                    ""id"": ""37c84f79-8c36-4f3c-ad63-52c6f2ba47d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""69b0b2b4-d8a9-4be0-945e-7e141747a321"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseDelta"",
                    ""type"": ""Value"",
                    ""id"": ""f4d82838-c59e-4970-bd38-3fd35321c96b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""1265a02f-e114-4e0c-821c-b9bad776359f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD_Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e83bd21b-d27c-41e2-aa65-1b9a2189003e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c571f534-99e6-4798-ad40-db5b16f67af7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""854973ee-b119-42f8-8176-11009531d89c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a26a47cd-069e-4a1b-aebc-985588fe3b6d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WASD_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9c401026-2782-403c-b4c8-9a78c5835fb5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""71793d64-20e1-45bc-b649-fe73c62d0e48"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseDelta"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerActionsMap"",
            ""id"": ""0220fe6a-32eb-468e-85b9-afc67a8bd357"",
            ""actions"": [
                {
                    ""name"": ""UseItem"",
                    ""type"": ""Button"",
                    ""id"": ""a7c76682-10e8-4638-a6a9-1ddfffed42b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MainAction"",
                    ""type"": ""Button"",
                    ""id"": ""53c5cabe-fcdb-4ce3-98b7-d59b96510153"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dc5575a3-b5cf-406b-b17e-16804f6bf9f7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""UseItem"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61dc9b47-67ea-4a4c-a935-1ef4df6e6128"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerMainMap
        m_PlayerMainMap = asset.FindActionMap("PlayerMainMap", throwIfNotFound: true);
        m_PlayerMainMap_WASD_Move = m_PlayerMainMap.FindAction("WASD_Move", throwIfNotFound: true);
        m_PlayerMainMap_Jump = m_PlayerMainMap.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMainMap_MouseDelta = m_PlayerMainMap.FindAction("MouseDelta", throwIfNotFound: true);
        // PlayerActionsMap
        m_PlayerActionsMap = asset.FindActionMap("PlayerActionsMap", throwIfNotFound: true);
        m_PlayerActionsMap_UseItem = m_PlayerActionsMap.FindAction("UseItem", throwIfNotFound: true);
        m_PlayerActionsMap_MainAction = m_PlayerActionsMap.FindAction("MainAction", throwIfNotFound: true);
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

    // PlayerMainMap
    private readonly InputActionMap m_PlayerMainMap;
    private List<IPlayerMainMapActions> m_PlayerMainMapActionsCallbackInterfaces = new List<IPlayerMainMapActions>();
    private readonly InputAction m_PlayerMainMap_WASD_Move;
    private readonly InputAction m_PlayerMainMap_Jump;
    private readonly InputAction m_PlayerMainMap_MouseDelta;
    public struct PlayerMainMapActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerMainMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @WASD_Move => m_Wrapper.m_PlayerMainMap_WASD_Move;
        public InputAction @Jump => m_Wrapper.m_PlayerMainMap_Jump;
        public InputAction @MouseDelta => m_Wrapper.m_PlayerMainMap_MouseDelta;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMainMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMainMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerMainMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerMainMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerMainMapActionsCallbackInterfaces.Add(instance);
            @WASD_Move.started += instance.OnWASD_Move;
            @WASD_Move.performed += instance.OnWASD_Move;
            @WASD_Move.canceled += instance.OnWASD_Move;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MouseDelta.started += instance.OnMouseDelta;
            @MouseDelta.performed += instance.OnMouseDelta;
            @MouseDelta.canceled += instance.OnMouseDelta;
        }

        private void UnregisterCallbacks(IPlayerMainMapActions instance)
        {
            @WASD_Move.started -= instance.OnWASD_Move;
            @WASD_Move.performed -= instance.OnWASD_Move;
            @WASD_Move.canceled -= instance.OnWASD_Move;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MouseDelta.started -= instance.OnMouseDelta;
            @MouseDelta.performed -= instance.OnMouseDelta;
            @MouseDelta.canceled -= instance.OnMouseDelta;
        }

        public void RemoveCallbacks(IPlayerMainMapActions instance)
        {
            if (m_Wrapper.m_PlayerMainMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerMainMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerMainMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerMainMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerMainMapActions @PlayerMainMap => new PlayerMainMapActions(this);

    // PlayerActionsMap
    private readonly InputActionMap m_PlayerActionsMap;
    private List<IPlayerActionsMapActions> m_PlayerActionsMapActionsCallbackInterfaces = new List<IPlayerActionsMapActions>();
    private readonly InputAction m_PlayerActionsMap_UseItem;
    private readonly InputAction m_PlayerActionsMap_MainAction;
    public struct PlayerActionsMapActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionsMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @UseItem => m_Wrapper.m_PlayerActionsMap_UseItem;
        public InputAction @MainAction => m_Wrapper.m_PlayerActionsMap_MainAction;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionsMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActionsMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsMapActionsCallbackInterfaces.Add(instance);
            @UseItem.started += instance.OnUseItem;
            @UseItem.performed += instance.OnUseItem;
            @UseItem.canceled += instance.OnUseItem;
            @MainAction.started += instance.OnMainAction;
            @MainAction.performed += instance.OnMainAction;
            @MainAction.canceled += instance.OnMainAction;
        }

        private void UnregisterCallbacks(IPlayerActionsMapActions instance)
        {
            @UseItem.started -= instance.OnUseItem;
            @UseItem.performed -= instance.OnUseItem;
            @UseItem.canceled -= instance.OnUseItem;
            @MainAction.started -= instance.OnMainAction;
            @MainAction.performed -= instance.OnMainAction;
            @MainAction.canceled -= instance.OnMainAction;
        }

        public void RemoveCallbacks(IPlayerActionsMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionsMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActionsMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActionsMapActions @PlayerActionsMap => new PlayerActionsMapActions(this);
    public interface IPlayerMainMapActions
    {
        void OnWASD_Move(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseDelta(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsMapActions
    {
        void OnUseItem(InputAction.CallbackContext context);
        void OnMainAction(InputAction.CallbackContext context);
    }
}
