using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteracPressurePlate : MonoBehaviour
{
    [SerializeField] private GameObject doorGameObject;
    private IDoor door;
    private float timer;

    private void Awake()
    {
        door = doorGameObject.GetComponent<IDoor>();
    }

    private void update()
    {
        if(timer > 0)
        {
            timer -=Time.deltaTime;
            if(timer <= 0f)
                door.CloseDoor();
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.GetComponent<Player>()!=null)
        {
            door.OpenDoor();
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if(collider.GetComponent<Player>()!=null)
            timer = 1f;
    }
}
