using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void ReachOutHand()
    {
         anim.SetTrigger("touchHair");
    }

    private void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("touchingHair"))
        {
            gameObject.SetActive(true);
        }
        
    }
}
