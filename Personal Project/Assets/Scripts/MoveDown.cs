using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody enemyRb;
    private float zBoundry = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRb.AddForce(Vector3.forward*-speed);
        DestroyInvisibleEnemy();
    }
    void DestroyInvisibleEnemy()
    {
        if(transform.position.z < zBoundry)
        {
            Destroy(gameObject);
        }
    }
}
