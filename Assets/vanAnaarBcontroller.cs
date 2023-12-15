using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanAnaarBcontroller : MonoBehaviour
{
    [SerializeField] GameObject A, B, Ball;
    [SerializeField] float speed;
    [SerializeField] GameObject Target;
    // Start is called before the first frame update
    void Start()
    {
        Ball.transform.position = A.transform.position;
        Target = B;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = Target.transform.position - Ball.transform.position;
        Ball.transform.position += delta.normalized * speed * Time.deltaTime;

        if (delta.magnitude < 0.1f){
            Target = Target == A? B : A;
        }
    }
}
