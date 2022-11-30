using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour, Controls.IPlayerActions
{
    private int speedHash = Animator.StringToHash("Speed");
    private int jumpHash = Animator.StringToHash("Jump");
    private int groundedHash = Animator.StringToHash("Grounded");
    private int fallHash = Animator.StringToHash("FreeFall");
    CharacterController controller;
    [SerializeField] private Rigidbody rbComponent;
    [SerializeField] private Animator animator;
    private Controls controls;
    private Vector2 inputDirection;
    private float forceMagnitude;

    public void OnMovement(InputAction.CallbackContext context){
        inputDirection = context.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext context){
        if(controller.isGrounded){
            forceMagnitude = 0.3f;
        }
        
    }

    void Start()
    {
        controls = new Controls();
        controls.player.Enable();
        controls.player.SetCallbacks(this);

        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        forceMagnitude-= Time.deltaTime;
        Vector3 movement = new Vector3(
            inputDirection.x / 12,
            forceMagnitude,
            inputDirection.y / 12
        );
        controller.Move(movement);

        if(!controller.isGrounded){
            animator.SetBool(jumpHash, true);
        }else{
            animator.SetBool(jumpHash, false);
            animator.SetBool(groundedHash, true);
        }

        if(Mathf.Abs(movement.x) >= 0 || Mathf.Abs(movement.z) >= 0){
            animator.SetFloat(speedHash, 1f);
        }else{
            animator.SetFloat(speedHash, 0);
        }
        
    }

    
}
