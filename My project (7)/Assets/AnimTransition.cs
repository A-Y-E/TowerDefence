using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = this.gameObject.GetComponent<Animator>();
        animator.speed = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}