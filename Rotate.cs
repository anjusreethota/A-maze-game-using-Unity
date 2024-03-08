using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 Rotateamount;
    public float Speed;
    //private 
    //the rotateamount name can be changed
    //c# is case sensitive



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(5, 3, 5);--PREDEFINED SPEED IN THE X,Y,Z COMPONENTS static
        //transform.Rotate(Rotateamount);
        transform.Rotate(Rotateamount* Speed);//dynamic
    }
}
//monobehaviour--inheritance parent and its children are start and update
//vector 3 for 3d game and vector2 for 2d game
//prefab is used to inherit the properties in that folder objects
//is trigger player gets destroyed
