// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerController.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerController : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerController"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""cb4bcf56-6a4e-4e91-89bf-b3bdb82ed567"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMovement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""21c82654-03da-4f3c-a01a-967a33045af0"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""ea2a811a-5f11-45d8-be9e-50fb1f0d9bec"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1c803cf2-c8c9-4e98-8640-dae47ba3d4a0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac440edb-9088-4847-88bd-02402b22ffaa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7922f3f8-8c9e-4b96-a5c6-73da87e96f3f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8518bb55-c91d-45c1-a4e8-2c75f998e653"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Action"",
            ""id"": ""f7ab5df5-15ab-4896-83f8-be9dab9a0f59"",
            ""actions"": [
                {
                    ""name"": ""Light"",
                    ""type"": ""Button"",
                    ""id"": ""e9a99ed2-0ad6-44e0-9b3a-5620d18a32a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Item"",
                    ""type"": ""Button"",
                    ""id"": ""dc1e78d1-f10d-4075-900d-252097059eb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""012366b5-496e-420a-960e-c91a46b8fb80"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d85063be-d073-4058-b14a-ad7b1f012b19"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Light"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""650b6e07-d310-4f49-bcf7-f387d1bd2636"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f788c69c-3091-4242-8e76-4077e0f43d9a"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_HorizontalMovement = m_Movement.FindAction("HorizontalMovement", throwIfNotFound: true);
        // Action
        m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
        m_Action_Light = m_Action.FindAction("Light", throwIfNotFound: true);
        m_Action_Item = m_Action.FindAction("Item", throwIfNotFound: true);
        m_Action_Menu = m_Action.FindAction("Menu", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_HorizontalMovement;
    public struct MovementActions
    {
        private @PlayerController m_Wrapper;
        public MovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Movement_HorizontalMovement;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @HorizontalMovement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
                @HorizontalMovement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnHorizontalMovement;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Action
    private readonly InputActionMap m_Action;
    private IActionActions m_ActionActionsCallbackInterface;
    private readonly InputAction m_Action_Light;
    private readonly InputAction m_Action_Item;
    private readonly InputAction m_Action_Menu;
    public struct ActionActions
    {
        private @PlayerController m_Wrapper;
        public ActionActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Light => m_Wrapper.m_Action_Light;
        public InputAction @Item => m_Wrapper.m_Action_Item;
        public InputAction @Menu => m_Wrapper.m_Action_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void SetCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterface != null)
            {
                @Light.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnLight;
                @Light.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnLight;
                @Light.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnLight;
                @Item.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnItem;
                @Item.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnItem;
                @Item.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnItem;
                @Menu.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_ActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Light.started += instance.OnLight;
                @Light.performed += instance.OnLight;
                @Light.canceled += instance.OnLight;
                @Item.started += instance.OnItem;
                @Item.performed += instance.OnItem;
                @Item.canceled += instance.OnItem;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public ActionActions @Action => new ActionActions(this);
    public interface IMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
    }
    public interface IActionActions
    {
        void OnLight(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
