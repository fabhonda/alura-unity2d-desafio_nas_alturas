using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimation : MonoBehaviour
{
    private SpriteRenderer srenderHand;
    // Start is called before the first frame update
    void Awake()
    {
        srenderHand = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            srenderHand.enabled = false;
        }
    }
}
