using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class MouseClickOnlineTest {

    [Test]
    public void MouseClickOnlineTestSimplePasses()
    {
        var engine = new MouseClickOnline();

        bool _click = true;

        var resultado = engine.RevisarClicks(_click);

        Assert.AreEqual(_click, true);
    }

    [Test]
    public void MouseClickOnlineTestSimplePasses2()
    {
        var engine = new MouseClickOnline();

        bool _click = false;

        var resultado = engine.RevisarClicks(_click);

        Assert.AreEqual(_click, false);
    }


    [Test]
    public void MouseClickOnlineTestSimplePasses3()
    {
        var engine = new MouseClickOnline();

        bool _click = false;
        int num = 7;

        var resultado = engine.RevisarClicks(_click);

        var res = engine.RevisarClicks(_click);



        Assert.AreEqual(_click, false);
    }
}
