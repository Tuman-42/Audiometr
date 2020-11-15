using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class sounds : MonoBehaviour
{
    private int counter = 0;
    private string[] texts = {"", "250 ГЦ", "500 ГЦ", "750 ГЦ", "1000 ГЦ", "1500 ГЦ", "2000 ГЦ", "3000 ГЦ", "6000 ГЦ", "8000 ГЦ", "" };
    private float[] pitchs = { 0, 1 / 32f, 1 / 16f, 3 / 32f, 1 / 8f, 3 / 16f, 1 / 4f, 3 / 8f, 3 / 4f, 1, 0 };
    private bool first = true;
    public float[] volume = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    public GameObject pref;
    public Canvas can;

    public AudioSource item;
    public Text text;
    public GameObject Test2;
    public void count()
    {
        if (counter < 10)
            counter++;
    }

    public void create()
    {
        for (int i = 1; i < 9; i++)
        {
            var pointer = Instantiate(pref) as GameObject;
            pointer.transform.SetParent(can.transform);
            pointer.transform.localPosition = new Vector2(-100f + i * 22f, -100f + 2000f * volume[i]);
        }
    }

    void Update()
    {
        text.text = texts[counter];
        volume[counter] += Time.deltaTime / 90f;

        if (volume[counter] > 1 && texts[counter]!="")
            count();

        item.pitch = pitchs[counter];
        item.volume = volume[counter];

        if (counter == 10)
        {
            Test2.SetActive(true);
            if (first)
            {
                first = false;
                create();
            }
        }
    }
}
