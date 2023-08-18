using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revive : MonoBehaviour
{
    // Start is called before the first frame update
    public void Revive()
    {
        GameManager.Instance.Revive();
    }
}
