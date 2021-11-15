// GENERATED AUTOMATICALLY FROM 'Assets/EntireGameInputSystem.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @EntireGameInputSystem : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @EntireGameInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EntireGameInputSystem"",
    ""maps"": [
        {
            ""name"": ""Master"",
            ""id"": ""8cc9ec34-c63f-4ef6-84ce-f38d87a61637"",
            ""actions"": [
                {
                    ""name"": ""MouseLook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""68d9b9a5-eb93-4f44-8a88-f1cfc1931d4f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2d0d8539-1ab3-4cb9-9230-8cb7ec1989fb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5bc9df3b-a864-4d6a-88dc-0080bacb665c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause Button"",
                    ""type"": ""Button"",
                    ""id"": ""36c700a6-63c3-4e82-9423-0f866a9212ec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f35d6f23-b6ac-42c4-8a5d-9511db2b8977"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""fea00877-49c7-46aa-bada-998e8fd07a6f"",
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
                    ""id"": ""f7b702fc-acab-4a27-ba6e-a42b081ea438"",
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
                    ""id"": ""ec918995-73d3-47a9-be4a-871ac6160fd4"",
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
                    ""id"": ""56de48a5-d628-49dc-b14b-5550bba727ed"",
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
                    ""id"": ""319d4405-be26-4a25-8894-ff378ece4606"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""68c9c5e2-16ef-4f32-8e7d-206bb3579dcc"",
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
                    ""id"": ""4edae631-916e-48d7-9fb5-0c6574d54a10"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Master
        m_Master = asset.FindActionMap("Master", throwIfNotFound: true);
        m_Master_MouseLook = m_Master.FindAction("MouseLook", throwIfNotFound: true);
        m_Master_Movement = m_Master.FindAction("Movement", throwIfNotFound: true);
        m_Master_Jump = m_Master.FindAction("Jump", throwIfNotFound: true);
        m_Master_PauseButton = m_Master.FindAction("Pause Button", throwIfNotFound: true);
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

    // Master
    private readonly InputActionMap m_Master;
    private IMasterActions m_MasterActionsCallbackInterface;
    private readonly InputAction m_Master_MouseLook;
    private readonly InputAction m_Master_Movement;
    private readonly InputAction m_Master_Jump;
    private readonly InputAction m_Master_PauseButton;
    public struct MasterActions
    {
        private @EntireGameInputSystem m_Wrapper;
        public MasterActions(@EntireGameInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseLook => m_Wrapper.m_Master_MouseLook;
        public InputAction @Movement => m_Wrapper.m_Master_Movement;
        public InputAction @Jump => m_Wrapper.m_Master_Jump;
        public InputAction @PauseButton => m_Wrapper.m_Master_PauseButton;
        public InputActionMap Get() { return m_Wrapper.m_Master; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MasterActions set) { return set.Get(); }
        public void SetCallbacks(IMasterActions instance)
        {
            if (m_Wrapper.m_MasterActionsCallbackInterface != null)
            {
                @MouseLook.started -= m_Wrapper.m_MasterActionsCallbackInterface.OnMouseLook;
                @MouseLook.performed -= m_Wrapper.m_MasterActionsCallbackInterface.OnMouseLook;
                @MouseLook.canceled -= m_Wrapper.m_MasterActionsCallbackInterface.OnMouseLook;
                @Movement.started -= m_Wrapper.m_MasterActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_MasterActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_MasterActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_MasterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MasterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MasterActionsCallbackInterface.OnJump;
                @PauseButton.started -= m_Wrapper.m_MasterActionsCallbackInterface.OnPauseButton;
                @PauseButton.performed -= m_Wrapper.m_MasterActionsCallbackInterface.OnPauseButton;
                @PauseButton.canceled -= m_Wrapper.m_MasterActionsCallbackInterface.OnPauseButton;
            }
            m_Wrapper.m_MasterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseLook.started += instance.OnMouseLook;
                @MouseLook.performed += instance.OnMouseLook;
                @MouseLook.canceled += instance.OnMouseLook;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @PauseButton.started += instance.OnPauseButton;
                @PauseButton.performed += instance.OnPauseButton;
                @PauseButton.canceled += instance.OnPauseButton;
            }
        }
    }
    public MasterActions @Master => new MasterActions(this);
    public interface IMasterActions
    {
        void OnMouseLook(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnPauseButton(InputAction.CallbackContext context);
    }
}
