using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ObtenerNivelTest {

    [Test]
    public void ObtenerNivelTestSimplePasses1()
    {
        var engine = new ObtenerNivel();

        string NivelFacil = "ScoreEasy";

        var result = engine.RegresarNombreDelNivel(8);

        Assert.AreEqual(NivelFacil, result);


    }

    [Test]
    public void ObtenerNivelTestSimplePasses2()
    {
        var engine = new ObtenerNivel();

        string NivelNormal = "ScoreNormal";

        var result = engine.RegresarNombreDelNivel(9);

        Assert.AreEqual(NivelNormal, result);


    }

    [Test]
    public void ObtenerNivelTestSimplePasses3()
    {
        var engine = new ObtenerNivel();

        string NivelHard = "ScoreHard";


        var result = engine.RegresarNombreDelNivel(10);

        Assert.AreEqual(NivelHard, result);


    }

    [Test]
    public void ObtenerNivelTestSimplePasses4()
    {
        var engine = new ObtenerNivel();

        string NivelExtream = "ScoreExpert";

        var result = engine.RegresarNombreDelNivel(11);

        Assert.AreEqual(NivelExtream, result);


    }

    [Test]
    public void ObtenerNivelTestSimplePasses5()
    {
        var engine = new ObtenerNivel();

        var result = engine.RegresarNombreDelNivel(0);

        Assert.AreEqual(null, result);


    }
}
