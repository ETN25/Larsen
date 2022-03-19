using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Movement movementScript;
    
    PlayerController controls;
    PlayerController.MovementActions movement;

    Vector2 horizontalInput;

    private void Awake()
    {
        controls = new PlayerController();
        movement = controls.Movement;

        movement.HorizontalMovement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }
    private void OnDisable()
    {
        controls.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movementScript.ReceiveInput(horizontalInput);
    }
}
