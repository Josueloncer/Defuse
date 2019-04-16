﻿using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CondicionVictoriaJ1Test {

    [Test]
    public void CondicionVictoriaJ1TestSimplePasses()
    {
        int _FocosPrendidos = 5;
        int _FocosParaGanar = 5;

        var engine = new CondicionVictoriaJ1();

        bool result = engine.condiciondevictoria(_FocosPrendidos, _FocosParaGanar);

        Assert.IsTrue(result);


    }

    [Test]
    public void CondicionVictoriaJ1TestSimplePasses2()
    {
        int _FocosPrendidos = 6;
        int _FocosParaGanar = 5;

        var engine = new CondicionVictoriaJ1();

        bool result = engine.condiciondevictoria(_FocosPrendidos, _FocosParaGanar);

        Assert.IsFalse(result);


    }
}
