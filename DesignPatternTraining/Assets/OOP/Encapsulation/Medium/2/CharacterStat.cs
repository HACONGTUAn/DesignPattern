using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterStat
{
    private Text textShow;
    private float cradleAt;
    public float CradleAt { 
        get { return cradleAt; } 
        private set {
            cradleAt = value;
            textShow.text = value.ToString();
        } }
    public CharacterStat( float cradleAt, Text textShow)
    {
        this.textShow = textShow;
        CradleAt = cradleAt;
    }
}
