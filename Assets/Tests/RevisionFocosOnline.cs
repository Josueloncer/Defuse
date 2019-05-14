using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class RevisionFocosOnlineTest {

    

    [Test]
    public void RevisionFocosOnlineTestSimplePasses1()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 0;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal+1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses2()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 1;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses3()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 2;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses4()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 3;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses5()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 4;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses6()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 5;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses7()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 6;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }
    [Test]
    public void RevisionFocosOnlineTestSimplePasses8()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 7;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses9()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 8;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }

    [Test]
    public void RevisionFocosOnlineTestSimplePasses10()
    {

        int Tapfinal = 1;
        int NumeroDeLista = 1;
        int NumeroDeFocosPrendidos = 9;

        var engine = new Revision();

        var result = engine.RevisionResultado(Tapfinal, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsTrue(result);

        var result2 = engine.RevisionResultado(Tapfinal + 1, NumeroDeLista, NumeroDeFocosPrendidos);

        Assert.IsFalse(result2);

    }
}
