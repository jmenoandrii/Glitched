// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""GroundMovement"",
            ""id"": ""ea2ab6f1-3699-4377-95d6-5eb5e81dd3e4"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c523e8b1-fadd-422b-a59e-4f7826eb3fb4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""1aa6ce64-6874-4fce-a111-af274512a89f"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8190b992-bdd4-45f1-9c02-43ce93ac62ed"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""de77e1ae-5159-4d3f-b3ef-cf94408b1d43"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""92efadce-c108-4f13-922f-a15a4e3b743c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94572fbb-35ed-4fdf-85ea-581c63abb4da"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""15487541-da01-4042-af69-042edde3b92a"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""076398b1-20b4-4337-961e-49aaea5c7978"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""078efd92-4759-4e17-851e-c2dca5ec8d85"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1a988c41-b476-41c4-af6b-85f3ce83c922"",
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
                    ""id"": ""a1248547-3591-473f-a762-d1fc5adf3967"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e6de527c-7fab-46e7-9be2-88c536ddcaa1"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Flashlights"",
            ""id"": ""4d2be752-0dca-466c-898b-80b0537f794e"",
            ""actions"": [
                {
                    ""name"": ""Switch"",
                    ""type"": ""Button"",
                    ""id"": ""e2e8d219-153e-4864-abd2-bf251f12a934"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c92b551-21da-4751-a018-c60c6f966238"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Menu"",
            ""id"": ""0c6716a7-bc8e-45cd-b7d2-175c99087e36"",
            ""actions"": [
                {
                    ""name"": ""Exit or Restart"",
                    ""type"": ""Button"",
                    ""id"": ""11bfa3f4-c718-42ea-81e7-909d2ef27807"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Close Game"",
                    ""type"": ""Button"",
                    ""id"": ""785b461a-0d3d-4fc6-b0ff-5e963ba24a84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6a915100-2e5f-475b-aab8-4c6f4a96ed87"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Exit or Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6edc4a35-43c5-4853-a342-f52b127d510d"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMovement
        m_GroundMovement = asset.FindActionMap("GroundMovement", throwIfNotFound: true);
        m_GroundMovement_Horizontal = m_GroundMovement.FindAction("Horizontal", throwIfNotFound: true);
        m_GroundMovement_MouseX = m_GroundMovement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMovement_MouseY = m_GroundMovement.FindAction("MouseY", throwIfNotFound: true);
        m_GroundMovement_Run = m_GroundMovement.FindAction("Run", throwIfNotFound: true);
        // Flashlights
        m_Flashlights = asset.FindActionMap("Flashlights", throwIfNotFound: true);
        m_Flashlights_Switch = m_Flashlights.FindAction("Switch", throwIfNotFound: true);
        // Menu
        m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
        m_Menu_ExitorRestart = m_Menu.FindAction("Exit or Restart", throwIfNotFound: true);
        m_Menu_CloseGame = m_Menu.FindAction("Close Game", throwIfNotFound: true);
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

    // GroundMovement
    private readonly InputActionMap m_GroundMovement;
    private IGroundMovementActions m_GroundMovementActionsCallbackInterface;
    private readonly InputAction m_GroundMovement_Horizontal;
    private readonly InputAction m_GroundMovement_MouseX;
    private readonly InputAction m_GroundMovement_MouseY;
    private readonly InputAction m_GroundMovement_Run;
    public struct GroundMovementActions
    {
        private @PlayerControls m_Wrapper;
        public GroundMovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_GroundMovement_Horizontal;
        public InputAction @MouseX => m_Wrapper.m_GroundMovement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMovement_MouseY;
        public InputAction @Run => m_Wrapper.m_GroundMovement_Run;
        public InputActionMap Get() { return m_Wrapper.m_GroundMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMovementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMovementActions instance)
        {
            if (m_Wrapper.m_GroundMovementActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnHorizontal;
                @MouseX.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnMouseY;
                @Run.started -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_GroundMovementActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_GroundMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public GroundMovementActions @GroundMovement => new GroundMovementActions(this);

    // Flashlights
    private readonly InputActionMap m_Flashlights;
    private IFlashlightsActions m_FlashlightsActionsCallbackInterface;
    private readonly InputAction m_Flashlights_Switch;
    public struct FlashlightsActions
    {
        private @PlayerControls m_Wrapper;
        public FlashlightsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Switch => m_Wrapper.m_Flashlights_Switch;
        public InputActionMap Get() { return m_Wrapper.m_Flashlights; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlashlightsActions set) { return set.Get(); }
        public void SetCallbacks(IFlashlightsActions instance)
        {
            if (m_Wrapper.m_FlashlightsActionsCallbackInterface != null)
            {
                @Switch.started -= m_Wrapper.m_FlashlightsActionsCallbackInterface.OnSwitch;
                @Switch.performed -= m_Wrapper.m_FlashlightsActionsCallbackInterface.OnSwitch;
                @Switch.canceled -= m_Wrapper.m_FlashlightsActionsCallbackInterface.OnSwitch;
            }
            m_Wrapper.m_FlashlightsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Switch.started += instance.OnSwitch;
                @Switch.performed += instance.OnSwitch;
                @Switch.canceled += instance.OnSwitch;
            }
        }
    }
    public FlashlightsActions @Flashlights => new FlashlightsActions(this);

    // Menu
    private readonly InputActionMap m_Menu;
    private IMenuActions m_MenuActionsCallbackInterface;
    private readonly InputAction m_Menu_ExitorRestart;
    private readonly InputAction m_Menu_CloseGame;
    public struct MenuActions
    {
        private @PlayerControls m_Wrapper;
        public MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ExitorRestart => m_Wrapper.m_Menu_ExitorRestart;
        public InputAction @CloseGame => m_Wrapper.m_Menu_CloseGame;
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
        public void SetCallbacks(IMenuActions instance)
        {
            if (m_Wrapper.m_MenuActionsCallbackInterface != null)
            {
                @ExitorRestart.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitorRestart;
                @ExitorRestart.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitorRestart;
                @ExitorRestart.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnExitorRestart;
                @CloseGame.started -= m_Wrapper.m_MenuActionsCallbackInterface.OnCloseGame;
                @CloseGame.performed -= m_Wrapper.m_MenuActionsCallbackInterface.OnCloseGame;
                @CloseGame.canceled -= m_Wrapper.m_MenuActionsCallbackInterface.OnCloseGame;
            }
            m_Wrapper.m_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ExitorRestart.started += instance.OnExitorRestart;
                @ExitorRestart.performed += instance.OnExitorRestart;
                @ExitorRestart.canceled += instance.OnExitorRestart;
                @CloseGame.started += instance.OnCloseGame;
                @CloseGame.performed += instance.OnCloseGame;
                @CloseGame.canceled += instance.OnCloseGame;
            }
        }
    }
    public MenuActions @Menu => new MenuActions(this);
    public interface IGroundMovementActions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
    public interface IFlashlightsActions
    {
        void OnSwitch(InputAction.CallbackContext context);
    }
    public interface IMenuActions
    {
        void OnExitorRestart(InputAction.CallbackContext context);
        void OnCloseGame(InputAction.CallbackContext context);
    }
}
