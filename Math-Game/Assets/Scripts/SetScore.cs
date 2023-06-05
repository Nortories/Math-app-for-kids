using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetScore : MonoBehaviour
{
    [SerializeField] GameObject score;
    [SerializeField] GameObject self;

    // Update is called once per frame
    void Update()
    {
        self.name = score.name;
    }
}
