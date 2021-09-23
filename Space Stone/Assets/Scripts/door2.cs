using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class door2 : MonoBehaviour
{
    public InputField answer;

    public GameObject door;
    public GameObject door2img;
    //[SerializeField] private Animator MyAnimationController;

    public void onSubmit()
    {
        if(answer.text == "4")
        {
            door.SetActive(false);
            door2img.SetActive(false);
            Debug.Log("You did it!");
        //    MyAnimationController.SetBool("play_anim", true);
        }
        else
            Debug.Log("Try Again!");
    }
}
