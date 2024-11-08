using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowScore : MonoBehaviour
{
  void FixedUpdate()
    {
        GetComponent<TextMeshProUGUI>().text = Data.score.ToString("Kamu Mendapatkan Keris 0");
    }
}
