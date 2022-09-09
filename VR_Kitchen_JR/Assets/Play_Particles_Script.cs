using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play_Particles_Script : MonoBehaviour
{
    [SerializeField] private ParticleSystem Ps;
    [SerializeField] bool grabbed, buttonPressed;
    public void Ungrabbed()
    {
        grabbed = false;
        Ps.Stop();
    }
    public void Grabbed()
    {
        grabbed = true;
    }
    public void ButtonPressed()
    {
        buttonPressed = true;
        if (grabbed && buttonPressed)
        {
            Ps.Play();
        }
    }
    public void ButtonRelased()
    {
        buttonPressed = false;
        Ps.Stop();
    }

}