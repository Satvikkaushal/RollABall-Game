using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class callbackfunc : MonoBehaviour
{
        void OnEnable()
        {
            Debug.Log("To");
        }

        void Update()
        {
            Debug.Log("Rythmos");
        }

        void LateUpdate()
        {
            Debug.Log("Family");
        }

        void FixedUpdate()
        {
            Debug.Log("from");
        }

        void Start()
        {
            Debug.Log("Freshers");
        }

        void Awake()
        {
        Debug.Log("Welcome");
        }
    }
