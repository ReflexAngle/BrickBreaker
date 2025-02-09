using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
// Bradley Petersen
//  02 - 08 - 2025
public class PlayerPaddle : MonoBehaviour
{
    [SerializeField, Range(1, 20)] private float moveSpeed = 1f;
    [SerializeField, Range(10, 29)] private float maxSpeed = 25f;

    protected Vector3 aMoveDirection = Vector3.zero;
    void OnEnable(){

    }
    void OnDisable(){

    }
    void Update(){
        MovePaddle();
    }
    // take inout from action
    public void MoveInput(InputAction.CallbackContext aCon){
        Vector2 aV2 = aCon.ReadValue<Vector2>();

        aMoveDirection.x = aV2.x;
        //aMoveDirection.z = aV2.y;
    }

    // move player
    public void MovePaddle(){
        if (aMoveDirection.magnitude > maxSpeed){
            return; // I dont care if it isnt nesassary Im keeping it
        }else{
            transform.Translate(aMoveDirection * moveSpeed * Time.deltaTime);
        }
        

    }
}
