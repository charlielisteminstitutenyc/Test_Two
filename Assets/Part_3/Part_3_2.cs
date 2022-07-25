using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Part_3_2 : MonoBehaviour
{
    //Attach this Script to Part_3_Cube
    Transform hi;
    Transform mynameis;
    Transform charlieli;
    void Start()
    {
        //Using PrintOutNameAndPosition print out the name and position of the Part_3_Cube (1pt)
        hi = GameObject.Find("Part_3_Cube").GetComponent<Transform>();
        PrintOutNameAndPosition(hi.name, hi.position);

        //using GameObject.Find get the transform of Part_3_Sphere and use PrintOutNameAndPosition (1pt)
        mynameis = GameObject.Find("Part_3_Sphere").GetComponent<Transform>();
        PrintOutNameAndPosition(mynameis.name, mynameis.position);

        //Using transform.Find or transform.Get get the Transform of Part_3_Cylinder which is a child of Part_3_Sphere
        //and use PrintOutNameAndPosition (1pt)
        charlieli = GameObject.Find("Part_3_Cylinder").GetComponent<Transform>();
        PrintOutNameAndPosition(charlieli.name, charlieli.position);

    }

    //Prints out the name and the position of the variables
    private void PrintOutNameAndPosition(string name, Vector3 pos)
    {
        print(name + " " + pos);
    }

}
