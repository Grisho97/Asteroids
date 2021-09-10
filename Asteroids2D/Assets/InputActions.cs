// GENERATED AUTOMATICALLY FROM 'Assets/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""SpaceShip"",
            ""id"": ""79469bf6-2dc1-460e-baab-dd05b3af965c"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""2f1f9ddf-0077-4cf0-914d-0161b64952fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""529e4022-6b22-472a-9e52-218094c24d17"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""1c914f8e-dc77-4fed-a6e7-54a8a0acb442"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnAsteroid"",
                    ""type"": ""Button"",
                    ""id"": ""1ebdaacb-7e2c-43cf-8212-4812d312d766"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpawnUfo"",
                    ""type"": ""Button"",
                    ""id"": ""9105812f-c41d-4c3f-a1a5-7df234f4e432"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Laser"",
                    ""type"": ""Button"",
                    ""id"": ""967c428d-f488-400b-aaaf-ba846f570a3b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ff8ffd6a-fe97-475d-954b-52c23b67f439"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f766be5-5a2a-43ef-9caa-8a754d247d4a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Rotate1"",
                    ""id"": ""d6b0e447-b619-47ed-aa9d-98e16a581cdf"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""acbc3642-5e4b-4a8f-b215-48647fe403bb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""901601b2-d6c2-41c0-ba52-d32190da03c0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Rotate2"",
                    ""id"": ""6d92974a-83c9-4908-80db-039d502b3e85"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ed9d94ef-29bb-4995-8661-47cccce326fc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c9f08666-7c08-41c3-a119-8f4ebdfd5683"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""93e02709-7b18-4fa4-8cd0-1b3f4e3809d2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fe9f80be-e748-4a1c-aa1c-14fe2b2aa30b"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9607b1c4-6a3e-424e-a64f-cfd1e818ac2c"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""SpawnAsteroid"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b05cccff-96fd-48d0-a79e-e630dabfa692"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""SpawnUfo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e55273f5-ea23-4d53-9b80-4f1ed69d1b01"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Laser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d3960c9d-1759-4ee8-9247-208f732240f6"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Laser"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
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
        }
    ]
}");
        // SpaceShip
        m_SpaceShip = asset.FindActionMap("SpaceShip", throwIfNotFound: true);
        m_SpaceShip_Shoot = m_SpaceShip.FindAction("Shoot", throwIfNotFound: true);
        m_SpaceShip_Rotate = m_SpaceShip.FindAction("Rotate", throwIfNotFound: true);
        m_SpaceShip_Move = m_SpaceShip.FindAction("Move", throwIfNotFound: true);
        m_SpaceShip_SpawnAsteroid = m_SpaceShip.FindAction("SpawnAsteroid", throwIfNotFound: true);
        m_SpaceShip_SpawnUfo = m_SpaceShip.FindAction("SpawnUfo", throwIfNotFound: true);
        m_SpaceShip_Laser = m_SpaceShip.FindAction("Laser", throwIfNotFound: true);
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

    // SpaceShip
    private readonly InputActionMap m_SpaceShip;
    private ISpaceShipActions m_SpaceShipActionsCallbackInterface;
    private readonly InputAction m_SpaceShip_Shoot;
    private readonly InputAction m_SpaceShip_Rotate;
    private readonly InputAction m_SpaceShip_Move;
    private readonly InputAction m_SpaceShip_SpawnAsteroid;
    private readonly InputAction m_SpaceShip_SpawnUfo;
    private readonly InputAction m_SpaceShip_Laser;
    public struct SpaceShipActions
    {
        private @InputActions m_Wrapper;
        public SpaceShipActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_SpaceShip_Shoot;
        public InputAction @Rotate => m_Wrapper.m_SpaceShip_Rotate;
        public InputAction @Move => m_Wrapper.m_SpaceShip_Move;
        public InputAction @SpawnAsteroid => m_Wrapper.m_SpaceShip_SpawnAsteroid;
        public InputAction @SpawnUfo => m_Wrapper.m_SpaceShip_SpawnUfo;
        public InputAction @Laser => m_Wrapper.m_SpaceShip_Laser;
        public InputActionMap Get() { return m_Wrapper.m_SpaceShip; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SpaceShipActions set) { return set.Get(); }
        public void SetCallbacks(ISpaceShipActions instance)
        {
            if (m_Wrapper.m_SpaceShipActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnShoot;
                @Rotate.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnRotate;
                @Move.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnMove;
                @SpawnAsteroid.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnAsteroid;
                @SpawnAsteroid.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnAsteroid;
                @SpawnAsteroid.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnAsteroid;
                @SpawnUfo.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnUfo;
                @SpawnUfo.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnUfo;
                @SpawnUfo.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnSpawnUfo;
                @Laser.started -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnLaser;
                @Laser.performed -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnLaser;
                @Laser.canceled -= m_Wrapper.m_SpaceShipActionsCallbackInterface.OnLaser;
            }
            m_Wrapper.m_SpaceShipActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @SpawnAsteroid.started += instance.OnSpawnAsteroid;
                @SpawnAsteroid.performed += instance.OnSpawnAsteroid;
                @SpawnAsteroid.canceled += instance.OnSpawnAsteroid;
                @SpawnUfo.started += instance.OnSpawnUfo;
                @SpawnUfo.performed += instance.OnSpawnUfo;
                @SpawnUfo.canceled += instance.OnSpawnUfo;
                @Laser.started += instance.OnLaser;
                @Laser.performed += instance.OnLaser;
                @Laser.canceled += instance.OnLaser;
            }
        }
    }
    public SpaceShipActions @SpaceShip => new SpaceShipActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface ISpaceShipActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnSpawnAsteroid(InputAction.CallbackContext context);
        void OnSpawnUfo(InputAction.CallbackContext context);
        void OnLaser(InputAction.CallbackContext context);
    }
}
