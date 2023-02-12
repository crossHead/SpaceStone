using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class InterdimensionalTransort : MonoBehaviour
{

    public Material[] materials;
    public Transform device;

    bool wasInFront = false;
    bool inOtherWorld = false;
    // Start is called before the first frame update
    void Start()
    {
        SetMaterials(false);
    }

    void SetMaterials(bool fullRender){
        var stencilTest = fullRender ? CompareFunction.NotEqual : CompareFunction.Equal;

        foreach (var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)stencilTest);
            }
    }

    bool GetIsInFront(){
        Vector3 pos = transform.InverseTransformPoint(device.position);
        
        return pos.z >= 0;
    }

    void OnTriggerEnter(Collider other) {
        if(other.transform != device){
            return;
        }

        wasInFront = GetIsInFront();
    }

    void OnTriggerStay(Collider other) {
        
        if(other.transform != device){
            return;
        }
        bool isInFront = GetIsInFront();
        if((isInFront && !wasInFront) || (wasInFront && !isInFront)){
            inOtherWorld = !inOtherWorld;
            SetMaterials(inOtherWorld);
        }

        wasInFront = isInFront;
        // if(other.name != "Main Camera") return;

        // //outside of otherworld
        // if(transform.position.z < other.transform.position.z){
        //     Debug.Log("outside of otherworld");
        //     foreach (var mat in materials)
        //     {
        //         mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        //     }
        // }
        // //inside other dimension
        // else{
        //     Debug.Log("inside of otherworld");
        //     foreach (var mat in materials)
        //     {
        //         mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        //     }
        // }
    }

    void OnDestroy() {
        SetMaterials(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
