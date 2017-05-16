using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmmaBehaviour : MonoBehaviour
{
    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Shrugg()
    {
        anim.SetTrigger("shrugg");
    }

    public void Dismissive()
    {
        anim.SetTrigger("dismissive");
    }

    public void ShakeHead()
    {
        anim.SetTrigger("shakehead");
    }

    public void AnnoyedNod()
    {
        anim.SetTrigger("annoyednod");
    }
    
}
