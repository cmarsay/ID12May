using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAnimation : MonoBehaviour
{

    [SerializeField] private Animator myAnimationController;

    private void OnTriggerEnter(Collider other)
    {
        myAnimationController.SetBool("Play", true);
    }


    public  void PredictPlay()
    {
        myAnimationController.SetBool("Play", true);
    }

}
