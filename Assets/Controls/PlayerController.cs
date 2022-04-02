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
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a5e0d469-6faf-4e44-b75b-83c009f16353"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5d741099-326d-40f8-b790-5db42f91a48e"",
                    ""expectedControlType"": ""Axis"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""48080200-f73d-470b-8119-703e9bcae31a"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3356183c-0aae-4f42-9136-1d81c46ddd7f"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                },
                {
                    ""name"": ""OS"",
                    ""type"": ""Button"",
                    ""id"": ""ecc636b3-7998-4100-b8ff-f7bfe9a28928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SB"",
                    ""type"": ""Button"",
                    ""id"": ""dea5822c-4bfa-4218-b268-947823084a9a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BP"",
                    ""type"": ""Button"",
                    ""id"": ""95db5c57-eaac-494c-b1ba-2493a21fe3d5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d85063be-d073-4058-b14a-ad7b1f012b19"",
                    ""path"": ""<Keyboard>/e"",
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
                    ""path"": ""<Keyboard>/q"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""820bda73-e3c0-4c17-952c-e627747957ff"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""OS"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a5af9d72-48e3-45d6-b70e-7a3fd29234a1"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SB"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa18b96b-dd79-443b-9274-458b25532875"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BP"",
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
        m_Movement_MouseX = m_Movement.FindAction("MouseX", throwIfNotFound: true);
        m_Movement_MouseY = m_Movement.FindAction("MouseY", throwIfNotFound: true);
        // Action
        m_Action = asset.FindActionMap("Action", throwIfNotFound: true);
        m_Action_Light = m_Action.FindAction("Light", throwIfNotFound: true);
        m_Action_Item = m_Action.FindAction("Item", throwIfNotFound: true);
        m_Action_Menu = m_Action.FindAction("Menu", throwIfNotFound: true);
        m_Action_OS = m_Action.FindAction("OS", throwIfNotFound: true);
        m_Action_SB = m_Action.FindAction("SB", throwIfNotFound: true);
        m_Action_BP = m_Action.FindAction("BP", throwIfNotFound: true);
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
    private readonly InputAction m_Movement_MouseX;
    private readonly InputAction m_Movement_MouseY;
    public struct MovementActions
    {
        private @PlayerController m_Wrapper;
        public MovementActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement => m_Wrapper.m_Movement_HorizontalMovement;
        public InputAction @MouseX => m_Wrapper.m_Movement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_Movement_MouseY;
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
                @MouseX.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMouseY;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMovement.started += instance.OnHorizontalMovement;
                @HorizontalMovement.performed += instance.OnHorizontalMovement;
                @HorizontalMovement.canceled += instance.OnHorizontalMovement;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
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
    private readonly InputAction m_Action_OS;
    private readonly InputAction m_Action_SB;
    private readonly InputAction m_Action_BP;
    public struct ActionActions
    {
        private @PlayerController m_Wrapper;
        public ActionActions(@PlayerController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Light => m_Wrapper.m_Action_Light;
        public InputAction @Item => m_Wrapper.m_Action_Item;
        public InputAction @Menu => m_Wrapper.m_Action_Menu;
        public InputAction @OS => m_Wrapper.m_Action_OS;
        public InputAction @SB => m_Wrapper.m_Action_SB;
        public InputAction @BP => m_Wrapper.m_Action_BP;
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
                @OS.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnOS;
                @OS.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnOS;
                @OS.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnOS;
                @SB.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnSB;
                @SB.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnSB;
                @SB.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnSB;
                @BP.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnBP;
                @BP.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnBP;
                @BP.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnBP;
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
                @OS.started += instance.OnOS;
                @OS.performed += instance.OnOS;
                @OS.canceled += instance.OnOS;
                @SB.started += instance.OnSB;
                @SB.performed += instance.OnSB;
                @SB.canceled += instance.OnSB;
                @BP.started += instance.OnBP;
                @BP.performed += instance.OnBP;
                @BP.canceled += instance.OnBP;
            }
        }
    }
    public ActionActions @Action => new ActionActions(this);
    public interface IMovementActions
    {
        void OnHorizontalMovement(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
    }
    public interface IActionActions
    {
        void OnLight(InputAction.CallbackContext context);
        void OnItem(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnOS(InputAction.CallbackContext context);
        void OnSB(InputAction.CallbackContext context);
        void OnBP(InputAction.CallbackContext context);
    }
}
