using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float Speed;
    private Rigidbody2D MoonPiss;
    private Vector3 PissColorChange;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        MoonPiss = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        PissColorChange = Vector3.zero;
        PissColorChange.x = Input.GetAxis("Horizontal");
        PissColorChange.y = Input.GetAxis("Vertical");

        if (PissColorChange != Vector3.zero){
            hahahaONE();
            animator.SetFloat("moveX", PissColorChange.x);
            animator.SetFloat("moveY", PissColorChange.y);
        }
    }
    void hahahaONE()
    {
        MoonPiss.MovePosition(
            transform.position + PissColorChange * Speed * Time.deltaTime
            );
    }
}
