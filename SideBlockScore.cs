using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global
{
    public static int Score = 100;
}

public class SideBlockScore : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "car")
        {
            Global.Score -= 5;
        }
    }
}
