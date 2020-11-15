using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createResult : MonoBehaviour
{
    public GameObject pref;
    public GameObject data;
    private float[] volume;
    public float coef = 10;
    public Canvas can;
    public void create()
    {
        sounds Component1 = data.GetComponent<sounds>();
        volume = Component1.volume;

        for (int i = 1; i < 9; i++)
        {
            var pointer = Instantiate(pref) as GameObject;
            pointer.transform.SetParent(can.transform);
            pointer.transform.position = new Vector2(-100f + i * 22f, -100 + 10 * volume[i]);
        }
    }
}
