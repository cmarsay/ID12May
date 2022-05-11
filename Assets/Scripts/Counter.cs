using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
      
    }

   

    private void OnTriggerEnter(Collider other)
    {
       


            canvas.SetActive(true);
            Debug.Log("COLLLISSIOINNN");
        
    }
}
