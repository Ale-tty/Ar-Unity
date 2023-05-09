using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velociraptor : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void OnTrackingFound()
    {
        animator.Play("RaptorArmature|Raptor_Idle1_Anim");
    }
}
