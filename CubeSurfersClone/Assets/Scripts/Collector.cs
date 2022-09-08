using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField]
    private GameObject mainCube;
    float height;


    // Start is called before the first frame update
    void Start()
    {
        height = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        mainCube.transform.position = new Vector3(transform.position.x, height + 1 , transform.position.z);
        this.transform.localPosition = new Vector3(0,  height, 0);
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            height++;
            other.gameObject.GetComponent<Collectable>().Collected();
            other.gameObject.GetComponent<Collectable>().CorrectIndex(height-2.5f);
            other.gameObject.transform.parent = this.transform;


        }
    }
}
