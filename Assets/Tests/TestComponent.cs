using UnityEngine;
using System.Collections;
using System.Collections.Generic;

#pragma warning disable 0414

public class TestComponent : MonoBehaviour
{
    //
    // Fields
    //

    public int publicField = 0;
    public static int publicStaticField = 5;

    private byte m_byteField = 200;
    private short m_shortField = 2;
    private int m_integerField = 5;
    private long m_longField = 20L;
    private float m_floatField = 2.5f;
    private double m_doubleField = 100.0;

    private bool m_boolField = false;

    private string m_stringField = "Some string";

    private ETestEnum m_enumField;

    private Vector2 m_vector2Field;
    private Vector3 m_vector3Field;
    private Vector4 m_vector4Field;

    private Color m_color;

    private Sprite m_sprite;

    private TestClass m_instanceField = new TestClass();
    private IList<TestClass> m_listField = new List<TestClass>() { new TestClass() };
    private ITestInterface m_interfaceField = new TestClass();
    private TestClass m_childField = new TestChildClass();
    private TestStruct m_structField;

    //
    // Service definitions
    //

    private enum ETestEnum
    {
        Value1,
        Value2
    }

    private interface ITestInterface
    {
    }

    private class TestClass : ITestInterface
    {
        private static TestClass s_instance = null;

        private int m_someField = 500;

        public TestClass()
        {
            s_instance = this;
        }
    }

    private class TestChildClass : TestClass
    {
        private float m_childField = 50.0f;
    }

    private struct TestStruct
    {
        int x;
        int y;
    }
}

#pragma warning restore 0414