using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScript : MonoBehaviour
{
    //Солнце
    public Transform Sun;
    //Скорость вращения солнца
    public float SpeedOfSun;
    void Update()
    {
        //Затемнение и вращение солнца
        Sun.Rotate(new Vector3(SpeedOfSun, 0, 0));
    }
}
