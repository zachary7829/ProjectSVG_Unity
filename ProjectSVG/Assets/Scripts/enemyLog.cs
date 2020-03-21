using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyLog : Enemy
{
    public Transform target;
    public float chaseRaidus;
    public float attackRadius;
    public Transform homePosition;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Sonic").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }
    void CheckDistance()
    {
        if(Vector2.Distance(target.position, transform.position) <= chaseRaidus)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, attackRadius);
            }
        }
}
