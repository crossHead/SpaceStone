using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door4 : MonoBehaviour
{
[SerializeField] private Animator MyAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            MyAnimationController.SetBool("char_nearby", true);
            MyAnimationController.SetBool("char_nearby", true);
        }
    }
}