using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pants : MonoBehaviour
{
    [SerializeField] private Transform[] patrolPoints;
    [SerializeField] private float speed;
    private AnimatorHelper animatorHelper;
    private int count;
    private Vector3[] inicialPatrolPoints;
    private void Start()
    {
        count = 0;
        inicialPatrolPoints = new Vector3[patrolPoints.Length];
        for (int i = 0; i < patrolPoints.Length; i++)
        {
            inicialPatrolPoints[i] = patrolPoints[i].position;
        }
        animatorHelper = GetComponent<AnimatorHelper>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, inicialPatrolPoints[count]) < 0.1f)
        {
            count++;
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, inicialPatrolPoints[count], speed * Time.deltaTime);
            if(inicialPatrolPoints[count].x - transform.position.x > 0f)
            {
                animatorHelper.SetAnimation("PantsWalkingRight");
            }
            else
            {
                animatorHelper.SetReverseAnimation("PantsWalkingLeft");
            }
        }
        if (count >= patrolPoints.Length) 
        {
            count = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        if(collision.tag == "Player")
        {
            CheckPointManager.instance.Kill();
        }
    }
}
