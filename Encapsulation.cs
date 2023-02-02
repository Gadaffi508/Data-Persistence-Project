using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulation : MonoBehaviour
{
    [SerializeField]
    private GameObject _frontTires;
    [SerializeField]
    private GameObject _rearTires;

    public GameObject FrontRightTire { get; set; }
    public GameObject FrontLeftTire { get; set; }
    public GameObject RearRightTire { get; set; }
    public GameObject RearLeftTire { get; set; }

    private void Start()
    {
        // Instantiate Tires
        FrontRightTire = Instantiate(_frontTires);
        FrontLeftTire = Instantiate(_frontTires);

        RearRightTire = Instantiate(_rearTires);
        RearLeftTire = Instantiate(_rearTires);
    }
}
