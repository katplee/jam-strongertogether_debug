// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Input Detection/KeyboardInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @KeyboardInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @KeyboardInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""KeyboardInputs"",
    ""maps"": [
        {
            ""name"": ""TameMenu"",
            ""id"": ""acee97f5-ea19-4fd1-a72e-e3b4029c78df"",
            ""actions"": [
                {
                    ""name"": ""PressR"",
                    ""type"": ""PassThrough"",
                    ""id"": ""862f4fed-2167-496e-91ed-45aa1e0aa5e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f86427db-3c2a-4fc7-b587-49b78884bef4"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PressR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TameMenu
        m_TameMenu = asset.FindActionMap("TameMenu", throwIfNotFound: true);
        m_TameMenu_PressR = m_TameMenu.FindAction("PressR", throwIfNotFound: true);
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

    // TameMenu
    private readonly InputActionMap m_TameMenu;
    private ITameMenuActions m_TameMenuActionsCallbackInterface;
    private readonly InputAction m_TameMenu_PressR;
    public struct TameMenuActions
    {
        private @KeyboardInputs m_Wrapper;
        public TameMenuActions(@KeyboardInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @PressR => m_Wrapper.m_TameMenu_PressR;
        public InputActionMap Get() { return m_Wrapper.m_TameMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TameMenuActions set) { return set.Get(); }
        public void SetCallbacks(ITameMenuActions instance)
        {
            if (m_Wrapper.m_TameMenuActionsCallbackInterface != null)
            {
                @PressR.started -= m_Wrapper.m_TameMenuActionsCallbackInterface.OnPressR;
                @PressR.performed -= m_Wrapper.m_TameMenuActionsCallbackInterface.OnPressR;
                @PressR.canceled -= m_Wrapper.m_TameMenuActionsCallbackInterface.OnPressR;
            }
            m_Wrapper.m_TameMenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PressR.started += instance.OnPressR;
                @PressR.performed += instance.OnPressR;
                @PressR.canceled += instance.OnPressR;
            }
        }
    }
    public TameMenuActions @TameMenu => new TameMenuActions(this);
    public interface ITameMenuActions
    {
        void OnPressR(InputAction.CallbackContext context);
    }
}
