﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bahamutAnimationController : MonoBehaviour {
    private Animator animator;
    int direction = 0;
    public playerStatusController playerStatus;
    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
        playerStatus = this.GetComponent<playerStatusController>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetInteger("direction", playerStatus.getFaceDirection());
    }
}