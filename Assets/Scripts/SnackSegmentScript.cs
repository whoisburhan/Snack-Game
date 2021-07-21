using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnackSegmentScript : MonoBehaviour
{
    private  void OnEnable()
    {
        SnackController.OnInitialize += AutoDestroy;
    }

    private  void OnDisable()
    {
        SnackController.OnInitialize -= AutoDestroy;
    }
    private void AutoDestroy()
    {
        Destroy(this.gameObject);
    }
}
