using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField]
    GameObject Target;
    GameObject Object;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "SpawnEnemy")
    //    {
    //        if (Object == null)
    //            Object = Instantiate(Target, transform.position, transform.rotation);
    //    }
    //}

    private void Start()
    {
        Object = Instantiate(Target, transform.position, transform.rotation);
    }
}
