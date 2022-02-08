using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownFunctionUI : MonoBehaviour
{
    public GameObject SpotLight3;
    public GameObject SpotLight2;
    public GameObject SpotLight1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DropDownFunction(int value)
    {
        if (value == 0)
        {
            SpotLight1.SetActive(true);
            SpotLight2.SetActive(false);
            SpotLight3.SetActive(false);
        }
        if (value == 1)
        {
            SpotLight1.SetActive(false);
            SpotLight2.SetActive(true);
            SpotLight3.SetActive(false);
        }
        if (value == 2)
        {
            SpotLight1.SetActive(false);
            SpotLight2.SetActive(false);
            SpotLight3.SetActive(true);
        }
        if (value == 3)
        {
            SpotLight1.SetActive(true);
            SpotLight2.SetActive(true);
            SpotLight3.SetActive(true);
        }
        if (value == 4)
        {
            SpotLight1.SetActive(false);
            SpotLight2.SetActive(false);
            SpotLight3.SetActive(false);
        }
    }
}