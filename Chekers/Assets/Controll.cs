//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.5.1
//     from Assets/Controll.inputactions
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

public partial class @Controll: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controll()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controll"",
    ""maps"": [
        {
            ""name"": ""Touchscreen"",
            ""id"": ""c5277cab-fa3f-4732-89f6-1062bf7e00d2"",
            ""actions"": [
                {
                    ""name"": ""TouchPos0"",
                    ""type"": ""Value"",
                    ""id"": ""070af61f-dcd6-4381-a944-f8991180b12d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchPos1"",
                    ""type"": ""Value"",
                    ""id"": ""1457eb35-efb8-49f6-82ff-56e624df7b05"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Touch0Tap"",
                    ""type"": ""Button"",
                    ""id"": ""5e129dd4-2a6c-4768-b242-01bea104c9e0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Touch1Tap"",
                    ""type"": ""Button"",
                    ""id"": ""f6f2a075-86ba-49f3-9561-1f62c14e2136"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchDelta0"",
                    ""type"": ""Value"",
                    ""id"": ""847b07dd-bc59-4083-bf30-c5703ad35c83"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""TouchDelta1"",
                    ""type"": ""Value"",
                    ""id"": ""465b69ef-8b60-4692-862a-d7838dcc50ac"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""0f44963b-78de-475b-a38a-fa1397e9bdb9"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""TouchPos0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6204bc8-ae07-4006-a160-b5a5c97080eb"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""TouchPos1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""488ffd1f-a370-4455-9d4b-68d6cf92bc42"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""Touch0Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ed87febb-9374-402a-8bdd-44097a6684b0"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""Touch1Tap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cf375fcf-360c-46a8-8b7f-9e5b3cdf2dc8"",
                    ""path"": ""<Touchscreen>/touch0/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""TouchDelta0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ed5174c-0015-482d-8e48-ad4f284c0496"",
                    ""path"": ""<Touchscreen>/touch1/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Andriod"",
                    ""action"": ""TouchDelta1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Andriod"",
            ""bindingGroup"": ""Andriod"",
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
        // Touchscreen
        m_Touchscreen = asset.FindActionMap("Touchscreen", throwIfNotFound: true);
        m_Touchscreen_TouchPos0 = m_Touchscreen.FindAction("TouchPos0", throwIfNotFound: true);
        m_Touchscreen_TouchPos1 = m_Touchscreen.FindAction("TouchPos1", throwIfNotFound: true);
        m_Touchscreen_Touch0Tap = m_Touchscreen.FindAction("Touch0Tap", throwIfNotFound: true);
        m_Touchscreen_Touch1Tap = m_Touchscreen.FindAction("Touch1Tap", throwIfNotFound: true);
        m_Touchscreen_TouchDelta0 = m_Touchscreen.FindAction("TouchDelta0", throwIfNotFound: true);
        m_Touchscreen_TouchDelta1 = m_Touchscreen.FindAction("TouchDelta1", throwIfNotFound: true);
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

    // Touchscreen
    private readonly InputActionMap m_Touchscreen;
    private List<ITouchscreenActions> m_TouchscreenActionsCallbackInterfaces = new List<ITouchscreenActions>();
    private readonly InputAction m_Touchscreen_TouchPos0;
    private readonly InputAction m_Touchscreen_TouchPos1;
    private readonly InputAction m_Touchscreen_Touch0Tap;
    private readonly InputAction m_Touchscreen_Touch1Tap;
    private readonly InputAction m_Touchscreen_TouchDelta0;
    private readonly InputAction m_Touchscreen_TouchDelta1;
    public struct TouchscreenActions
    {
        private @Controll m_Wrapper;
        public TouchscreenActions(@Controll wrapper) { m_Wrapper = wrapper; }
        public InputAction @TouchPos0 => m_Wrapper.m_Touchscreen_TouchPos0;
        public InputAction @TouchPos1 => m_Wrapper.m_Touchscreen_TouchPos1;
        public InputAction @Touch0Tap => m_Wrapper.m_Touchscreen_Touch0Tap;
        public InputAction @Touch1Tap => m_Wrapper.m_Touchscreen_Touch1Tap;
        public InputAction @TouchDelta0 => m_Wrapper.m_Touchscreen_TouchDelta0;
        public InputAction @TouchDelta1 => m_Wrapper.m_Touchscreen_TouchDelta1;
        public InputActionMap Get() { return m_Wrapper.m_Touchscreen; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchscreenActions set) { return set.Get(); }
        public void AddCallbacks(ITouchscreenActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchscreenActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchscreenActionsCallbackInterfaces.Add(instance);
            @TouchPos0.started += instance.OnTouchPos0;
            @TouchPos0.performed += instance.OnTouchPos0;
            @TouchPos0.canceled += instance.OnTouchPos0;
            @TouchPos1.started += instance.OnTouchPos1;
            @TouchPos1.performed += instance.OnTouchPos1;
            @TouchPos1.canceled += instance.OnTouchPos1;
            @Touch0Tap.started += instance.OnTouch0Tap;
            @Touch0Tap.performed += instance.OnTouch0Tap;
            @Touch0Tap.canceled += instance.OnTouch0Tap;
            @Touch1Tap.started += instance.OnTouch1Tap;
            @Touch1Tap.performed += instance.OnTouch1Tap;
            @Touch1Tap.canceled += instance.OnTouch1Tap;
            @TouchDelta0.started += instance.OnTouchDelta0;
            @TouchDelta0.performed += instance.OnTouchDelta0;
            @TouchDelta0.canceled += instance.OnTouchDelta0;
            @TouchDelta1.started += instance.OnTouchDelta1;
            @TouchDelta1.performed += instance.OnTouchDelta1;
            @TouchDelta1.canceled += instance.OnTouchDelta1;
        }

        private void UnregisterCallbacks(ITouchscreenActions instance)
        {
            @TouchPos0.started -= instance.OnTouchPos0;
            @TouchPos0.performed -= instance.OnTouchPos0;
            @TouchPos0.canceled -= instance.OnTouchPos0;
            @TouchPos1.started -= instance.OnTouchPos1;
            @TouchPos1.performed -= instance.OnTouchPos1;
            @TouchPos1.canceled -= instance.OnTouchPos1;
            @Touch0Tap.started -= instance.OnTouch0Tap;
            @Touch0Tap.performed -= instance.OnTouch0Tap;
            @Touch0Tap.canceled -= instance.OnTouch0Tap;
            @Touch1Tap.started -= instance.OnTouch1Tap;
            @Touch1Tap.performed -= instance.OnTouch1Tap;
            @Touch1Tap.canceled -= instance.OnTouch1Tap;
            @TouchDelta0.started -= instance.OnTouchDelta0;
            @TouchDelta0.performed -= instance.OnTouchDelta0;
            @TouchDelta0.canceled -= instance.OnTouchDelta0;
            @TouchDelta1.started -= instance.OnTouchDelta1;
            @TouchDelta1.performed -= instance.OnTouchDelta1;
            @TouchDelta1.canceled -= instance.OnTouchDelta1;
        }

        public void RemoveCallbacks(ITouchscreenActions instance)
        {
            if (m_Wrapper.m_TouchscreenActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchscreenActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchscreenActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchscreenActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchscreenActions @Touchscreen => new TouchscreenActions(this);
    private int m_AndriodSchemeIndex = -1;
    public InputControlScheme AndriodScheme
    {
        get
        {
            if (m_AndriodSchemeIndex == -1) m_AndriodSchemeIndex = asset.FindControlSchemeIndex("Andriod");
            return asset.controlSchemes[m_AndriodSchemeIndex];
        }
    }
    public interface ITouchscreenActions
    {
        void OnTouchPos0(InputAction.CallbackContext context);
        void OnTouchPos1(InputAction.CallbackContext context);
        void OnTouch0Tap(InputAction.CallbackContext context);
        void OnTouch1Tap(InputAction.CallbackContext context);
        void OnTouchDelta0(InputAction.CallbackContext context);
        void OnTouchDelta1(InputAction.CallbackContext context);
    }
}
