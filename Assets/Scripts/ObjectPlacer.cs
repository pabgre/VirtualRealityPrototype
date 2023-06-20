using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectPlacer : MonoBehaviour
{
    [SerializeField]
    public Transform scan = null;
    [SerializeField]
    private GameObject gizmo = null;
    
    private Transform instantiated_obj = null;
    
    private XRIDefaultInputActions input = null;

    private void Awake()
    {
        input = new XRIDefaultInputActions();
    }

    private void OnEnable()
    {
        input.Enable();
        input.XRIRightHandInteraction.Activate.performed += OnTriggerPressed;
        input.XRIRightHandInteraction.Activate.canceled += OnTriggerReleased;
    }
    
    private void OnDisable()
    {
        input.Disable();
        input.XRIRightHandInteraction.Activate.performed -= OnTriggerPressed;
        input.XRIRightHandInteraction.Activate.canceled -= OnTriggerReleased;
    }

    private void OnTriggerPressed(InputAction.CallbackContext value)
    {
        instantiated_obj = Instantiate(gizmo, transform.position, Quaternion.identity, transform).transform;
    }
    private void OnTriggerReleased(InputAction.CallbackContext value)
    {
        instantiated_obj.transform.parent = scan;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
