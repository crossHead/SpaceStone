using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    public InputField answer;
    public string actualAns;
    public GameObject door;
   
    public GameObject door2img;
  //  [SerializeField] private Animator MyAnimationController;
    string input;

    public void onSubmit()
    {
        input = answer.text;
        if (input.ToUpper() == actualAns.ToUpper())
        {
            door.SetActive(false);
            door2img.SetActive(false);
            Debug.Log("You did it!");
           // MyAnimationController.SetBool("open", true);
          
        }
        else
            Debug.Log(input.ToUpper());
   
    }

}
