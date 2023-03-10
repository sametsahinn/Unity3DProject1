//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/GameFolders/Scripts/Concretes/Input/DefaltAction.inputactions
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

public partial class @DefaltAction : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DefaltAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DefaltAction"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""421b2078-3c69-499c-bffc-92874663d72c"",
            ""actions"": [
                {
                    ""name"": ""ForceUp"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ebe26fd9-182f-4623-b33e-e3138d4f9c86"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LeftRight"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a6ed496f-2b66-4079-bc40-31f6edc5f1d3"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cc298ffb-ad0e-4c5f-b4fd-06d99cc5edee"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ForceUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""AD"",
                    ""id"": ""929f9be5-0bff-473f-b1ff-734408257c6d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a15789b0-ac9f-44af-966d-d0a521dcf532"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3f3686dd-5e90-4bd2-ab30-916dd14541ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_ForceUp = m_Rocket.FindAction("ForceUp", throwIfNotFound: true);
        m_Rocket_LeftRight = m_Rocket.FindAction("LeftRight", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private IRocketActions m_RocketActionsCallbackInterface;
    private readonly InputAction m_Rocket_ForceUp;
    private readonly InputAction m_Rocket_LeftRight;
    public struct RocketActions
    {
        private @DefaltAction m_Wrapper;
        public RocketActions(@DefaltAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @ForceUp => m_Wrapper.m_Rocket_ForceUp;
        public InputAction @LeftRight => m_Wrapper.m_Rocket_LeftRight;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void SetCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterface != null)
            {
                @ForceUp.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                @ForceUp.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                @ForceUp.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnForceUp;
                @LeftRight.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                @LeftRight.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
                @LeftRight.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnLeftRight;
            }
            m_Wrapper.m_RocketActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ForceUp.started += instance.OnForceUp;
                @ForceUp.performed += instance.OnForceUp;
                @ForceUp.canceled += instance.OnForceUp;
                @LeftRight.started += instance.OnLeftRight;
                @LeftRight.performed += instance.OnLeftRight;
                @LeftRight.canceled += instance.OnLeftRight;
            }
        }
    }
    public RocketActions @Rocket => new RocketActions(this);
    public interface IRocketActions
    {
        void OnForceUp(InputAction.CallbackContext context);
        void OnLeftRight(InputAction.CallbackContext context);
    }
}
