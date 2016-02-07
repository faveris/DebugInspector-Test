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

    //
    // Service definitions
    //

    private enum ETestEnum
    {
        Value1,
        Value2
    }

    private class TestClass
    {
        private int m_someField = 500;
    }
}

#pragma warning restore 0414