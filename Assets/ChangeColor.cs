using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;
    public Renderer[] mats;
    
    public void Red()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            mats[i].material.color = colors[0];
        }
    }

    public void Gold()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            mats[i].material.color = colors[1];
        }
    }

    public void Black()
    {
        for (int i = 0; i < mats.Length; i++)
        {
            mats[i].material.color = colors[2];
        }
    }
}
