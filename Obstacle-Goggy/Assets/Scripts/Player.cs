using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DodgeGame{
public class Player : MonoBehaviour
{

    [SerializeField] float moveSpeed = 10f;
    
    void Start()
    {
        PrintInstruction();
        
    }

    void Update()
    {
         
         MovePlayer();
    }


    void MovePlayer()
    {
        
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime *moveSpeed;
   
        float yValue = 0f;
    
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue,yValue,zValue);

    }
    void PrintInstruction()
    {
    Debug.Log("Welcome to the game!!!");
    Debug.Log("Move using arrow keys or WASD");
    Debug.Log("Welocme to the game!");
    }
}
}