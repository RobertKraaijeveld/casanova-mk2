﻿using UnityEngine;
using System.Collections;
using Casanova.Prelude;
using System.Collections.Generic;

public class UnityAppearanceStat : MonoBehaviour {

    private TextMesh AttackStat;
    private TextMesh DefenseStat;
    private TextMesh ProductivityStat;
    private TextMesh ResearchStat;
    private TextMesh NextShipIn;

  public static UnityAppearanceStat FindStat(UnityPlanet p)
  {
    var appearancestat = p.GetComponentInChildren<UnityAppearanceStat>() as UnityAppearanceStat;
    appearancestat.AttackStat = appearancestat.transform.FindChild("Attack").GetComponent<TextMesh>();
    appearancestat.DefenseStat = appearancestat.transform.FindChild("Defense").GetComponent<TextMesh>();
    appearancestat.ProductivityStat = appearancestat.transform.FindChild("Productivity").GetComponent<TextMesh>();
    appearancestat.ResearchStat = appearancestat.transform.FindChild("Research").GetComponent<TextMesh>();
    appearancestat.NextShipIn = appearancestat.transform.FindChild("NextShipIn").GetComponent<TextMesh>();
    return appearancestat;
  }


  public string AttackText
  {
    get { return AttackStat.text; }
    set { AttackStat.text = "A :" + value; }
  }

  public string DefenseText
  {
    get { return DefenseStat.text; }
    set { DefenseStat.text = "D :" + value; }
  }

  public string ProductivityText
  {
    get { return ProductivityStat.text; }
    set { ProductivityStat.text = "P :" + value; }
  }
  public string ResearchText
  {
    get { return ResearchStat.text; }
    set { ResearchStat.text = "R :" + value; }
  }
  public string NextShipInText
  {
      get { return NextShipIn.text; }
      set { NextShipIn.text = "NS :" + value; }
  }
}
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            