using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    private void FixedUpdate()
    {
        GetComponent<Text>().text = Data.score.ToString("000");
    }
}
