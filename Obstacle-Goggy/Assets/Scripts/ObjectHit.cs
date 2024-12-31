using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace DodgeGame{

public class ObjectHit : MonoBehaviour
{
     private void OnCollisionEnter(Collision other)
     {
        Debug.Log("Something hits me!");
     }
}
}