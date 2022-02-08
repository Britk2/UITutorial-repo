using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Object;//this needs to be set in inspector
    private Vector3 moveto;

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Follow Mouse");
        moveto = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        Object.transform.position = moveto;
    }
}
