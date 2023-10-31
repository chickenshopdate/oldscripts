using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MT_NoCollision : MonoBehaviour
{
    [SerializeField] GameObject[] objectsToIgnore; 
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < objectsToIgnore.Length; i++)
        {
            Physics2D.IgnoreCollision(GetComponent<Collider2D>(), objectsToIgnore[i].GetComponent<Collider2D>());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
