﻿using UnityEngine;

public class OpenField : MonoBehaviour
{
    [SerializeField] private GameObject[] coins = default;

    // Update is called once per frame
    private void Update()
    {
        if(coins[0].transform.localEulerAngles.z == 270 &&
            coins[1].transform.localEulerAngles.z == 0 &&
            coins[2].transform.localEulerAngles.z == 90 &&
            coins[3].transform.localEulerAngles.z == 270)
        {
            gameObject.SetActive(false);
        }
    }
}
