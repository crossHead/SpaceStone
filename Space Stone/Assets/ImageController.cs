using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageController : MonoBehaviour
{
 [SerializeField] private GameObject[] items;
    [SerializeField] private GameObject[] itemImage;
   
    string itemName;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position); 
            RaycastHit Hit;
            if (Physics.Raycast(ray, out Hit)){
                itemName = Hit.transform.name;

                for (int i = 0; i < items.Length; i++)
                {
                    if(itemName == items[i].transform.name){
                        itemImage[i].SetActive(true);
                    }
                }
                

               
            }
        }
        
    }
}
