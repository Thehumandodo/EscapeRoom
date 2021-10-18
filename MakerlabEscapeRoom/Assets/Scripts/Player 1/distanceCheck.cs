using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class distanceCheck : MonoBehaviour
{

    public GameObject right;
    public GameObject left;
    public GameObject top;
    public GameObject message;
    public float distance1, distance2;
    // Start is called before the first frame update
    void Start()
    {
        message.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        distance1 = Vector3.Distance(top.transform.position, left.transform.position);
        distance2 = Vector3.Distance(left.transform.position, right.transform.position);
        if(distance1 < 15 && distance2 <15){
            message.SetActive(true);
        }
        else
        {
            message.SetActive(false);
        }
    }
    
    

}
