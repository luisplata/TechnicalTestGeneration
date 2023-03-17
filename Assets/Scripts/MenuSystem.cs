using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSystem : MonoBehaviour
{
    [SerializeField] private GameObject panel;

    private bool _isActive;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(_isActive);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            _isActive = !_isActive;
            panel.SetActive(_isActive);
        }
    }
}
