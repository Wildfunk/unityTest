using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heberScript : MonoBehaviour
{
    private float horizontal;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        animator.SetBool("running", horizontal != 0.0f);
    }
}
