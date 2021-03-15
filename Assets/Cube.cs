﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    MainEvents.onClick += TurnRed;
  }

  public void TurnRed()
  {
    GetComponent<MeshRenderer>().material.color = Color.red;
  }

  private void OnDisable()
  {
    MainEvents.onClick -= TurnRed;
  }
}
