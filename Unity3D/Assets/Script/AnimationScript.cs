using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    Animator anim;
    [SerializeField]string AnimationName1;
    [SerializeField]string AnimationName2;
    [SerializeField]string AnimationName3;
    private void Awake() {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
    }
    public void PlayAnimation1()
    {
        anim.SetTrigger(AnimationName1);
    }
    public void PlayAnimation2()
    {
        anim.SetTrigger(AnimationName2);
    }
    public void PlayAnimation3()
    {
        anim.SetTrigger(AnimationName3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
